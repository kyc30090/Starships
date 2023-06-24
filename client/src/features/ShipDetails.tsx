import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import { Starship } from "../app/models/starship";
import DetailTemplate from "./DetailTemplate";
import agent from "../app/api/agent";

export default function ShipDetails() {
    const { id } = useParams<{ id: string }>();
    const [starship, setStarship] = useState<Starship | null>(null);
    const [loading, setLoading] = useState(true);

    useEffect(() => {
        id && agent.Starships.details(parseInt(id))
            .then(response => setStarship(response))
            .catch(error => console.log(error))
            .finally(() => setLoading(false))
    }, [id]);

    return (<DetailTemplate loading={loading} starship={starship} />);

}