import { Grid } from "@mui/material";
import { Starship } from "../app/models/starship";
import StarshipCard from "./StarshipCard";

interface Props {
    starships: Starship[];
}

export default function StarshipList({ starships }: Props) {
    return (
        <Grid container spacing={4}>
            {starships.map(starship => (
                <Grid item xs={3} key={starship.id}>
                    <StarshipCard starship={starship} />
                </Grid>
            ))}
        </Grid>
    )
}