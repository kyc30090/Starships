import { Typography } from "@mui/material";
import axios from "axios";
import { useState, useEffect } from "react";
import { Starship } from "../app/models/starship";
import DetailTemplate from "./DetailTemplate";
import agent from "../app/api/agent";

export default function HomePage() {
    const [starship, setStarship] = useState<Starship | null>(null);
    const [loading, setLoading] = useState(true);

    useEffect(() => {
        agent.Starships.random()
            .then(response => setStarship(response))
            .catch(error => console.log(error))
            .finally(() => setLoading(false))
    }, []);

    return (<DetailTemplate loading={loading} starship={starship} />);
}