import { Box, Typography, Button, Grid, Paper } from "@mui/material";
import agent from "../app/api/agent";
import { Starship } from "../app/models/starship";
import StarshipForm from "./StarshipForm";
import StarshipList from "./StarshipList";
import { useState, useEffect } from "react";
import RadioButtonGroup from "../app/components/RadioButtonGroup";
import CheckboxButtons from "../app/components/CheckboxButtons";
import AppPagination from "../app/components/AppPagination";
import { useAppDispatch, useAppSelector } from "../app/store/configureStore";
import { fetchFilters, fetchShipsAsync, starshipSelectors, setShipParams, setPageNumber, removeStarship } from "./catalogSlice";
import ShipSearch from "./ShipSearch";
import LoadingComponent from "../app/layout/LoadingComponent";

const sortOptions = [
    { value: 'name', label: 'Alphabetical' },
    { value: 'nameDesc', label: 'Alphabetical - z to a' },
    { value: 'id', label: 'ID' },
]

export default function Catalog() {
    const starships = useAppSelector(starshipSelectors.selectAll);
    const { shipsLoaded, filtersLoaded, shipClasses, shipParams, metaData } = useAppSelector(state => state.catalog);
    const dispatch = useAppDispatch();

    const [loading, setLoading] = useState(true);

    const [editMode, setEditMode] = useState(false);
    const [selectedShip, setSelectedShip] = useState<Starship | undefined>(undefined);

    useEffect(() => {
        if (!shipsLoaded) dispatch(fetchShipsAsync());
    }, [shipsLoaded, dispatch]);

    useEffect(() => {
        if (!filtersLoaded) dispatch(fetchFilters());
    }, [filtersLoaded, dispatch]);

    if (!filtersLoaded) return <LoadingComponent message='Loading star ships...' />;


    const handleCancelEdit = () => {
        if (selectedShip) setSelectedShip(undefined);
        setEditMode(false);
    }

    const handleSelectShip = (starship?: Starship) => {
        setSelectedShip(starship);
        setEditMode(true);
    }

    const handleDeleteShip = (id: number) => {
        setLoading(true);
        agent.Starships.delete(id)
            .then(() => dispatch(removeStarship(id)))
            .catch(error => console.log(error))
            .finally(() => setLoading(false));
    }

    if (editMode) return <StarshipForm starship={selectedShip} cancelEdit={handleCancelEdit} />;

    return (
        <Grid container columnSpacing={4}>
            <Grid item xs={3}>
                <Paper sx={{ mb: 2 }}>
                    <ShipSearch />
                </Paper>
                <Paper sx={{ p: 2, mb: 2 }}>
                    <RadioButtonGroup
                        selectedValue={shipParams.orderBy}
                        options={sortOptions}
                        onChange={(e) => dispatch(setShipParams({ orderBy: e.target.value }))}
                    />
                </Paper>
                <Paper sx={{ p: 2, mb: 2 }}>
                    <CheckboxButtons
                        items={shipClasses}
                        checked={shipParams.shipClasses}
                        onChange={(checkedItems: string[]) => dispatch(setShipParams({ shipClasses: checkedItems }))}
                    />
                </Paper>
            </Grid>
            <Grid item xs={9}>
                <Box display='flex' justifyContent='space-between'>
                    <Typography sx={{ p: 2 }} variant='h4'>Starships</Typography>
                    <Button onClick={() => setEditMode(true)} sx={{ m: 2 }} size='large' variant='contained'>Create</Button>
                </Box>
                <StarshipList starships={starships} handleSelectShip={handleSelectShip} handleDeleteShip={handleDeleteShip} />
            </Grid>
            <Grid item xs={3} />
            <Grid item xs={9} sx={{ mb: 2 }}>
                {metaData &&
                    <AppPagination
                        metaData={metaData}
                        onPageChange={(page: number) => dispatch(setPageNumber({ pageNumber: page }))}
                    />}
            </Grid>
        </Grid>
    )
}