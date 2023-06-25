import { createAsyncThunk, createEntityAdapter, createSlice } from "@reduxjs/toolkit";
import { Starship } from "../app/models/starship";
import agent from "../app/api/agent";
import { RootState } from "../app/store/configureStore";

const shipsAdapter = createEntityAdapter<Starship>();

export const fetchShipsAsync = createAsyncThunk<Starship[]>(
    'catalog/fetchShipsAsync',
    async () => {
        try {
            const response = await agent.Starships.list();
            return response?.results;
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

export const catalogSlice = createSlice({
    name: 'catalog',
    initialState: shipsAdapter.getInitialState({
        starshipsLoaded: false,
        status: 'idle'
    }),
    reducers: {
        // setShipParams: (state, action) => {
        //     state. = action.payload
        // }
    },
    extraReducers: (builder => {
        builder.addCase(fetchShipsAsync.pending, (state) => {
            state.status = 'pendingFetchShipsAsync';
        });
        builder.addCase(fetchShipsAsync.fulfilled, (state, action) => {
            shipsAdapter.setAll(state, action.payload);
            state.status = 'idle';
            state.starshipsLoaded = true;
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
    })
})

// export const { setShipParams } = catalogSlice.actions;

export const starshipSelectors = shipsAdapter.getSelectors((state: RootState) => state.catalog);