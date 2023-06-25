import { Grid } from "@mui/material";
import { Starship } from "../app/models/starship";
import StarshipCard from "./StarshipCard";
import { useAppSelector } from "../app/store/configureStore";
import ShipCardSkeleton from "./ShipCardSkeleton";

interface Props {
    starships: Starship[],
    handleSelectShip: (starship?: Starship) => void;
    handleDeleteShip: (id: number) => void;
}

export default function StarshipList({ starships, handleSelectShip, handleDeleteShip }: Props) {
    const { shipsLoaded } = useAppSelector(state => state.catalog);
    return (
        <Grid container spacing={4}>
            {starships.map(starship => (
                <Grid item xs={4} key={starship.id}>
                    {!shipsLoaded ?
                        (<ShipCardSkeleton />) :
                        (
                            <StarshipCard starship={starship}
                                handleSelectShip={handleSelectShip}
                                handleDeleteShip={handleDeleteShip}
                            />
                        )
                    }

                </Grid>
            ))}
        </Grid>
    )
}