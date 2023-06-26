import { Grid, Typography, Divider, TableContainer, Table, TableBody, TableRow, TableCell, Avatar, Stack, CardHeader } from "@mui/material";
import { Starship } from "../app/models/starship";
import { stringAvatar } from "./Pilots";

interface Props {
    loading: boolean;
    starship: Starship | null;
}

export default function DetailTemplate({ loading, starship }: Props) {

    if (loading) return (<h3>Loading...</h3>);
    if (!starship) return (<h3>Not found</h3>);

    return (
        <Grid container spacing={6}>
            <Grid item xs={6}>
                <img src={starship.image} alt={starship.name} style={{ width: '100%' }} />
                <Divider sx={{ mb: 2 }} />
                {!!starship.films && starship.films?.length > 0 && (<>
                    <Typography variant='h6'>Films</Typography>
                    <Stack direction="row" spacing={2}>
                        {starship.films?.map(f => (
                            <Avatar>{f.episode_id}</Avatar>
                        ))}
                    </Stack> </>)}
                <Divider sx={{ m: 2 }} />
                {!!starship.pilots && starship.pilots?.length > 0 && (<>
                    <Typography variant='h6'>Pilots</Typography>
                    <Stack direction="column" spacing={2}>
                        {starship.pilots?.map(p => (
                            <CardHeader avatar={
                                <Avatar {...stringAvatar(p.name)} />}
                                title={p.name}
                            />
                        ))}
                    </Stack> </>)}
            </Grid>
            <Grid item xs={6}>
                <Typography variant='h2'>{starship.name}</Typography>
                <Divider sx={{ mb: 2 }} />
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