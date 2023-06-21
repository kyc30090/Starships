import agent from "../app/api/agent";
import { Starship } from "../app/models/starship";
import StarshipList from "./StarshipList";
import { useState, useEffect } from "react";

export default function Catalog() {
    const [starships, setStarships] = useState<Starship[]>([]);
    const [loading, setLoading] = useState(true);

    useEffect(() => {
        agent.Starships.list()
            .then(response => setStarships(response?.results))
            .catch(error => console.log(error))
            .finally(() => setLoading(false))
    }, []);

    if (loading) return (<h1>Loading...</h1>);

    return (
        <>
            <StarshipList starships={starships} />
            {/* <Button variant="contained" onClick={addStarship}>Add starship</Button> */}
        </>
    )
}