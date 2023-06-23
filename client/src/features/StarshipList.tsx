import { Grid } from "@mui/material";
import { Starship } from "../app/models/starship";
import StarshipCard from "./StarshipCard";

interface Props {
    starships: Starship[],
    handleSelectShip: (starship?: Starship) => void;
    handleDeleteShip: (id: number) => void;
}

export default function StarshipList({ starships, handleSelectShip, handleDeleteShip }: Props) {
    return (
        <Grid container spacing={4}>
            {starships.map(starship => (
                <Grid item xs={3} key={starship.id}>
                    <StarshipCard starship={starship}
                        handleSelectShip={handleSelectShip}
                        handleDeleteShip={handleDeleteShip}
                    />
                </Grid>
            ))}
        </Grid>
    )
}