import { Box, Typography, Button, Grid, Paper } from "@mui/material";
import agent from "../app/api/agent";
import { Starship } from "../app/models/starship";
import StarshipForm from "./StarshipForm";
import StarshipList from "./StarshipList";
import { useState, useEffect } from "react";
import types from "@emotion/styled";
import { ShipParams } from "../app/models/shipParams";
import RadioButtonGroup from "../app/components/RadioButtonGroup";
import CheckboxButtons from "../app/components/CheckboxButtons";
import AppPagination from "../app/components/AppPagination";
import { useAppDispatch, useAppSelector } from "../app/store/configureStore";
import { fetchShipsAsync, starshipSelectors } from "./catalogSlice";

const sortOptions = [
    { value: 'name', label: 'Alphabetical' },
    { value: 'nameDesc', label: 'Alphabetical - z to a' },
    { value: 'id', label: 'ID' },
]

export default function Catalog() {
    const starships = useAppSelector(starshipSelectors.selectAll);
    const { starshipsLoaded, status } = useAppSelector(state => state.catalog);
    const dispatch = useAppDispatch();
    
    const [loading, setLoading] = useState(true);

    const [editMode, setEditMode] = useState(false);
    const [selectedShip, setSelectedShip] = useState<Starship | undefined>(undefined);
    const [deleteId, setDeleteId] = useState(0);

    const [shipParams, setShipParams] = useState<ShipParams>();
    const [pageNumber, setPageNumber] = useState();

    // useEffect(() => {
    //     agent.Starships.list()
    //         .then(response => setStarships(response?.results))
    //         .catch(error => console.log(error))
    //         .finally(() => setLoading(false))
    // }, []);

    // if (loading) return (<h1>Loading...</h1>);


    useEffect(() => {
        if (!starshipsLoaded) dispatch(fetchShipsAsync());
    }, [starshipsLoaded]);

    if (status.includes('pending')) return (<h1>Loading...</h1>);


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
        setDeleteId(id);
        agent.Starships.delete(id)
            .then()
            .catch(error => console.log(error))
            .finally(() => setLoading(false));
    }

    if (editMode) return <StarshipForm starship={selectedShip} cancelEdit={handleCancelEdit} />;

    return (
        // <>
        //     <Box display='flex' justifyContent='space-between'>
        //         <Typography sx={{ p: 2 }} variant='h4'>Starships</Typography>
        //         <Button onClick={() => setEditMode(true)} sx={{ m: 2 }} size='large' variant='contained'>Create</Button>
        //     </Box>
        //     <StarshipList starships={starships} handleSelectShip={handleSelectShip} handleDeleteShip={handleDeleteShip} />
        // </>
        <Grid container columnSpacing={4}>
            <Grid item xs={3}>
                <Paper sx={{ mb: 2 }}>
                    Starship Search
                    {/* <StarshipSearch /> */}
                </Paper>
                <Paper sx={{ p: 2, mb: 2 }}>
                    Radiobutton groups order by
                    {/* <RadioButtonGroup
                        selectedValue={shipParams.orderBy}
                        options={sortOptions}
                        onChange={(e) => dispatch(setShipParams({ orderBy: e.target.value }))}
                    /> */}
                </Paper>
                <Paper sx={{ p: 2, mb: 2 }}>
                    Starship classes checkbox buttons filters
                    {/* <CheckboxButtons
                        items={shipClasses}
                        checked={shipParams.shipClasses}
                        onChange={(checkedItems: string[]) => dispatch(setShipParams({ shipClasses: checkedItems }))}
                    /> */}
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
                Pagination
                {/* {metaData &&
                    <AppPagination
                        metaData={metaData}
                        onPageChange={(page: number) => dispatch(setPageNumber({ pageNumber: page }))}
                    />} */}
            </Grid>
        </Grid>
    )
}