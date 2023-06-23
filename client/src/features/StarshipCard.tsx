import { Avatar, Button, Card, CardActions, CardContent, CardHeader, CardMedia, Typography } from "@mui/material";
import { Starship } from "../app/models/starship";
import { Link } from "react-router-dom";
import { Delete, Edit } from "@mui/icons-material";

interface Props {
    starship: Starship;
    handleSelectShip: (starship?: Starship) => void;
    handleDeleteShip: (id: number) => void;
}
export default function StarshipCard({ starship, handleSelectShip, handleDeleteShip }: Props) {
    return (
        <Card>
            <CardHeader
                avatar={
                    <Avatar sx={{ bgcolor: 'secondary.main' }}>
                        {starship.hyperdrive_rating}
                    </Avatar>
                }
                title={starship.name}
                titleTypographyProps={{
                    sx: { fontWeight: 'bold', color: 'primary.main' }
                }}
            />
            <CardMedia
                sx={{ height: 140, backgroundSize: 'contain', bgcolor: 'primary.light' }}
                image={"https://starwars-visualguide.com/assets/img/starships/9.jpg"}
                title={starship.name}
            />
            <CardContent>
                <Typography gutterBottom color='secondary' variant="subtitle1">
                    {starship.model}
                </Typography>
                <Typography variant="body2" color="text.secondary">
                    {starship.starship_class}
                </Typography>
            </CardContent>
            <CardActions>
                <Button component={Link} to={`/starships/${starship.id}`} size="small">View</Button>
                <Button startIcon={<Edit />} onClick={() => { handleSelectShip(starship) }} />
                <Button startIcon={<Delete />} onClick={() => { handleDeleteShip(starship.id) }} color='error' />
            </CardActions>
        </Card>
    )
}