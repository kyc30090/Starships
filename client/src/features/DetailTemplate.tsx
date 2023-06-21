import { Grid, Typography, Divider, TableContainer, Table, TableBody, TableRow, TableCell } from "@mui/material";
import { Starship } from "../app/models/starship";

interface Props {
    loading: boolean;
    starship: Starship | null;
}

export default function DetailTemplate({loading, starship}: Props) {

    if (loading) return (<h3>Loading...</h3>);
    if (!starship) return (<h3>Not found</h3>);

    return (
        <Grid container spacing={6}>
            <Grid item xs={6}>
                <img src={starship.imageUrl} alt={starship.name} style={{width: '100%'}} />
            </Grid>
            <Grid item xs={6}>
                <Typography variant='h2'>{starship.name}</Typography>
                <Divider sx={{mb: 2}} />
                <TableContainer>
                    <Table>
                        <TableBody>
                            <TableRow>
                                <TableCell>Model</TableCell>
                                <TableCell>{starship.model}</TableCell>
                            </TableRow>
                        </TableBody>
                        <TableBody>
                            <TableRow>
                                <TableCell>Manufacturer</TableCell>
                                <TableCell>{starship.manufacturer}</TableCell>
                            </TableRow>
                        </TableBody>
                        <TableBody>
                            <TableRow>
                                <TableCell>Cost In Credits</TableCell>
                                <TableCell>{starship.cost_in_credits}</TableCell>
                            </TableRow>
                        </TableBody>
                        <TableBody>
                            <TableRow>
                                <TableCell>Length</TableCell>
                                <TableCell>{starship.length}</TableCell>
                            </TableRow>
                        </TableBody>
                        <TableBody>
                            <TableRow>
                                <TableCell>Max Atmoshering Speed</TableCell>
                                <TableCell>{starship.max_atmosphering_speed}</TableCell>
                            </TableRow>
                        </TableBody>
                        <TableBody>
                            <TableRow>
                                <TableCell>Crew</TableCell>
                                <TableCell>{starship.crew}</TableCell>
                            </TableRow>
                        </TableBody>
                        <TableBody>
                            <TableRow>
                                <TableCell>Passengers</TableCell>
                                <TableCell>{starship.passengers}</TableCell>
                            </TableRow>
                        </TableBody>
                        <TableBody>
                            <TableRow>
                                <TableCell>Cargo Capacity</TableCell>
                                <TableCell>{starship.cargo_capacity}</TableCell>
                            </TableRow>
                        </TableBody>
                        <TableBody>
                            <TableRow>
                                <TableCell>Consumerables</TableCell>
                                <TableCell>{starship.consumables}</TableCell>
                            </TableRow>
                        </TableBody>
                        <TableBody>
                            <TableRow>
                                <TableCell>Hyperdrive Rating</TableCell>
                                <TableCell>{starship.hyperdrive_rating}</TableCell>
                            </TableRow>
                        </TableBody>
                        <TableBody>
                            <TableRow>
                                <TableCell>MGLT</TableCell>
                                <TableCell>{starship.MGLT}</TableCell>
                            </TableRow>
                        </TableBody>
                        <TableBody>
                            <TableRow>
                                <TableCell>Starship Class</TableCell>
                                <TableCell>{starship.starship_class}</TableCell>
                            </TableRow>
                        </TableBody>
                    </Table>
                </TableContainer>
            </Grid>
        </Grid>
        
    );
}