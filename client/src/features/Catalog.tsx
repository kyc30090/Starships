import { Box, Typography, Button } from "@mui/material";
import agent from "../app/api/agent";
import { Starship } from "../app/models/starship";
import StarshipForm from "./StarshipForm";
import StarshipList from "./StarshipList";
import { useState, useEffect } from "react";

export default function Catalog() {
    const [starships, setStarships] = useState<Starship[]>([]);
    const [loading, setLoading] = useState(true);

    const [editMode, setEditMode] = useState(false);
    const [selectedShip, setSelectedShip] = useState<Starship | undefined>(undefined);
    const [deleteId, setDeleteId] = useState(0);

    useEffect(() => {
        agent.Starships.list()
            .then(response => setStarships(response?.results))
            .catch(error => console.log(error))
            .finally(() => setLoading(false))
    }, []);

    if (loading) return (<h1>Loading...</h1>);


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
        <>
            <Box display='flex' justifyContent='space-between'>
                <Typography sx={{ p: 2 }} variant='h4'>Starships</Typography>
                <Button onClick={() => setEditMode(true)} sx={{ m: 2 }} size='large' variant='contained'>Create</Button>
            </Box>
            <StarshipList starships={starships} handleSelectShip={handleSelectShip} handleDeleteShip={handleDeleteShip} />
        </>
    )
}