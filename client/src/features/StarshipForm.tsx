import { Container, Paper, Typography, Box, TextField, Grid, Button } from "@mui/material";
import { LoadingButton } from '@mui/lab';
import { FieldValues, useForm } from "react-hook-form";
import { useNavigate } from "react-router-dom";
import agent from "../app/api/agent";
import AppDropzone from "../app/components/AppDropzone";
import { Starship } from "../app/models/starship";
import { useEffect } from "react";

interface Props {
    starship?: Starship;
    cancelEdit: () => void;
}

export default function StarshipForm({ starship, cancelEdit }: Props) {
    const { register, handleSubmit, setError, reset, control, watch,
        formState: { isSubmitting, errors, isValid } } = useForm({
            mode: 'onTouched'
        });
    const watchFile = watch('file', null);

    useEffect(() => {
        if (starship) {
            reset(starship);
        }

    }, [starship, reset]);

    const navigate = useNavigate();


    function handleApiErrors(errors: any) {
        console.log(errors);
        if (errors) {
            errors.forEach((error: string, index: number) => {
                if (error.includes('Password')) {
                    setError('password', { message: error })
                } else if (error.includes('Email')) {
                    setError('email', { message: error })
                } else if (error.includes('Username')) {
                    setError('username', { message: error })
                }
            });
        }
    }

    async function handleSubmitData(data: FieldValues) {
        try {
            let response: Starship;
            console.log(data)
            if (starship) {
                response = await agent.Starships.update(data);
            } else {
                response = await agent.Starships.create(data);
            }

            // dispatch(setStarship(response));
            cancelEdit();
        } catch (error) {
            console.log(error);
        }
    }

    return (
        <Container component={Paper} maxWidth='sm' sx={{ p: 4, display: 'flex', flexDirection: 'column', alignItems: 'center' }}>
            <Typography component="h1" variant="h5">
                Create Starship
            </Typography>
            <form onSubmit={handleSubmit(handleSubmitData)}>
                <Grid container spacing={3}>
                    <Grid item xs={12} sm={12}>
                        <TextField
                            required
                            fullWidth
                            label="Name"
                            autoFocus
                            size="small"
                            {...register('name', { required: 'Name is required' })}
                            error={!!errors.name}
                            helperText={errors?.name?.message as string}
                        />
                    </Grid>
                    <Grid item xs={12} sm={12}>
                        <TextField
                            required
                            fullWidth
                            label="Model"
                            size="small"
                            {...register('model', {
                                required: 'model is required'
                            })}
                            error={!!errors.model}
                            helperText={errors?.model?.message as string}
                        />
                    </Grid>
                    <Grid item xs={12} sm={12}>
                        <TextField
                            fullWidth
                            label="Starship Class"
                            size="small"
                            {...register('starship_class')}
                        />
                    </Grid>
                    <Grid item xs={12} sm={12}>
                        <TextField
                            fullWidth
                            label="Manufacturer"
                            size="small"
                            {...register('manufacturer')}
                        />
                    </Grid>
                    <Grid item xs={12} sm={6}>
                        <TextField
                            label="Cost In Credits"
                            fullWidth
                            size="small"
                            {...register('cost_in_credits')}
                        />
                    </Grid>
                    <Grid item xs={12} sm={6}>
                        <TextField
                            label="Length"
                            fullWidth
                            size="small"
                            {...register('length')}
                        />
                    </Grid>
                    <Grid item xs={12} sm={6}>
                        <TextField
                            fullWidth
                            size="small"
                            label="Max Atmoshering Speed"
                            {...register('max_atmosphering_speed')}
                        />
                    </Grid>
                    <Grid item xs={12} sm={6}>
                        <TextField
                            fullWidth
                            size="small"
                            label="Crew"
                            {...register('crew')}
                        />
                    </Grid>
                    <Grid item xs={12} sm={6}>
                        <TextField
                            fullWidth
                            size="small"
                            label="Passengers"
                            {...register('passengers')}
                        />
                    </Grid>
                    <Grid item xs={12} sm={6}>
                        <TextField
                            fullWidth
                            size="small"
                            label="Cargo Capacity"
                            {...register('cargo_capacity')}
                        />
                    </Grid>
                    <Grid item xs={12} sm={6}>
                        <TextField
                            fullWidth
                            label="Consumerables"
                            size="small"
                            {...register('consumerables')}
                        />
                    </Grid>
                    <Grid item xs={12} sm={6}>
                        <TextField
                            fullWidth
                            label="Hyperdrive Rating"
                            size="small"
                            {...register('hyperdrive_rating', {
                                min: 0.5,
                                max: 10
                            })}
                        />
                    </Grid>
                    <Grid item xs={12} sm={6}>
                        <TextField
                            fullWidth
                            label="MGLT"
                            size="small"
                            {...register('MGLT', {
                                min: 0,
                                max: 500
                            })}
                        />
                    </Grid>
                    <Grid item xs={12}>
                        <Box display='flex' justifyContent='space-between' alignItems='center'>
                            <AppDropzone control={control} name='file' />
                            {watchFile ? (
                                <img src={watchFile.preview} alt="preview" style={{ maxHeight: 200 }} />
                            ) : (
                                <img src={starship?.image} alt={starship?.name} style={{ maxHeight: 200 }} />
                            )}
                        </Box>

                    </Grid>

                </Grid>
                <Box display='flex' justifyContent='space-between'>
                    <Button onClick={cancelEdit} variant='contained' color='inherit'
                        sx={{ mt: 3, mb: 2 }}>
                        Cancel
                    </Button>
                    <LoadingButton
                        disabled={!isValid}
                        loading={isSubmitting}
                        type='submit'
                        variant='contained' sx={{ mt: 3, mb: 2 }}
                    >
                        Save
                    </LoadingButton>
                </Box>
            </form>
        </Container>
    );
}
