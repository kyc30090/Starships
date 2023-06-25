import { createAsyncThunk, createEntityAdapter, createSlice } from "@reduxjs/toolkit";
import { Starship } from "../app/models/starship";
import agent from "../app/api/agent";
import { RootState } from "../app/store/configureStore";
import { ShipParams } from "../app/models/shipParams";
import { MetaData } from "../app/models/pagination";

interface CatalogState {
    shipsLoaded: boolean;
    filtersLoaded: boolean;
    status: string;
    shipClasses: string[];
    shipParams: ShipParams;
    metaData: MetaData | null;
}

const shipsAdapter = createEntityAdapter<Starship>();

function getAxiosParams(shipParams: ShipParams) {
    const params = new URLSearchParams();
    params.append('pageNumber', shipParams.pageNumber.toString());
    params.append('pageSize', shipParams.pageSize.toString());
    params.append('orderBy', shipParams.orderBy);
    if (shipParams.searchTerm) params.append('searchTerm', shipParams.searchTerm);
    if (shipParams.shipClasses.length > 0) params.append('shipClasses', shipParams.shipClasses.toString());
    return params;
}
export const fetchShipsAsync = createAsyncThunk<Starship[], void, {state: RootState}>(
    'catalog/fetchShipsAsync',
    async (_, thunkAPI) => {
        const params = getAxiosParams(thunkAPI.getState().catalog.shipParams)
        try {
            const response = await agent.Starships.list(params);
            thunkAPI.dispatch(setMetaData(response.metaData));
            return response.items;
        } catch (error) {
            console.log(error);
        }
    }
)

export const fetchShipAsync = createAsyncThunk<Starship, number>(
    'catalog/fetchShipAsync',
    async (shipId) => {
        try {
            return await agent.Starships.details(shipId);
        } catch (error) {
            console.log(error);
        }
    }
)

export const fetchFilters = createAsyncThunk(
    'catalog/fetchFilters',
    async (_, thunkAPI) => {
        try {
            return agent.Starships.fetchFilters();
        } catch (error) {
            console.log(error);
        }
    }
)

function initParams() {
    return {
        pageNumber: 1,
        pageSize: 10,
        orderBy: 'name',
        shipClasses: []
    }
}

export const catalogSlice = createSlice({
    name: 'catalog',
    initialState: shipsAdapter.getInitialState<CatalogState>({
        shipsLoaded: false,
        filtersLoaded: false,
        status: 'idle',
        shipClasses: [],
        shipParams: initParams(),
        metaData: null
    }),
    reducers: {
        setShipParams: (state, action) => {
            state.shipsLoaded = false;
            state.shipParams = { ...state.shipParams, ...action.payload, pageNumber: 1 };
        },
        setMetaData: (state, action) => {
            state.metaData = action.payload;
        },
        setPageNumber: (state, action) => {
            state.shipsLoaded = false;
            state.shipParams = { ...state.shipParams, ...action.payload };
        },
        resetShipParams: (state) => {
            state.shipParams = initParams();
        }
    },
    extraReducers: (builder => {
        builder.addCase(fetchShipsAsync.pending, (state) => {
            state.status = 'pendingFetchShipsAsync';
        });
        builder.addCase(fetchShipsAsync.fulfilled, (state, action) => {
            shipsAdapter.setAll(state, action.payload);
            state.status = 'idle';
            state.shipsLoaded = true;
        });
        builder.addCase(fetchShipsAsync.rejected, (state) => {
            state.status = 'idle';
        });

        builder.addCase(fetchShipAsync.pending, (state) => {
            state.status = 'pendingFetchShipAsync';
        });
        builder.addCase(fetchShipAsync.fulfilled, (state, action) => {
            shipsAdapter.upsertOne(state, action.payload);
            state.status = 'idle';
        });
        builder.addCase(fetchShipAsync.rejected, (state) => {
            state.status = 'idle';
        });
        builder.addCase(fetchFilters.pending, (state) => {
            state.status = 'pendingFetchFilters';
        });
        builder.addCase(fetchFilters.fulfilled, (state, action) => {
            state.shipClasses = action.payload.shipClasses;
            state.filtersLoaded = true;
            state.status = 'idle';
        });
        builder.addCase(fetchFilters.rejected, (state, action) => {
            state.status = 'idle';
            console.log(action.payload);
        })
    })
})

export const starshipSelectors = shipsAdapter.getSelectors((state: RootState) => state.catalog);

export const { setShipParams, resetShipParams, setMetaData, setPageNumber } = catalogSlice.actions;