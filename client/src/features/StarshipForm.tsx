import {
  Container,
  Paper,
  Typography,
  Box,
  TextField,
  Grid,
  Button,
  FormLabel,
} from "@mui/material";
import { LoadingButton } from "@mui/lab";
import { FieldValues, useForm } from "react-hook-form";
import agent from "../app/api/agent";
import AppDropzone from "../app/components/AppDropzone";
import { Starship } from "../app/models/starship";
import { useEffect, useState } from "react";
import { useAppDispatch } from "../app/store/configureStore";
import { setStarship } from "./catalogSlice";
import AppTextInput from "../app/components/AppTextInput";
import { Film, FilmDto } from "../app/models/film";
import AppCheckboxGroup from "../app/components/AppCheckboxGroup";

interface Props {
  starship?: Starship;
  cancelEdit: () => void;
}

export default function StarshipForm({ starship, cancelEdit }: Props) {
  const {
    register,
    handleSubmit,
    setError,
    reset,
    control,
    watch,
    formState: { isSubmitting, errors, isValid, isDirty },
  } = useForm({
    mode: "onTouched",
  });
  const watchFile = watch("file", null);
  const dispatch = useAppDispatch();

  const [films, setFilms] = useState<FilmDto[]>([]);
  const [filmIds, setFilmIds] = useState<number[]>([]);

  useEffect(() => {
    if (starship && !watchFile && !isDirty) {
      reset(starship);
    }
    return () => {
      if (watchFile) URL.revokeObjectURL(watchFile.preview);
    };
  }, [starship, reset, watchFile, isDirty]);

  useEffect(() => {
    agent.Films.list()
      .then((response) => setFilms(response))
      .catch((error) => console.log(error));
  }, []);

  async function handleSubmitData(data: FieldValues) {
    try {
      let response: Starship;
      data.filmIds = filmIds;
      console.log(data);
      if (starship) {
        response = await agent.Starships.update(data);
      } else {
        response = await agent.Starships.create(data);
      }

      dispatch(setStarship(response));
      cancelEdit();
    } catch (error) {
      console.log(error);
    }
  }

  return (
    <Container
      component={Paper}
      maxWidth="sm"
      sx={{
        p: 4,
        display: "flex",
        flexDirection: "column",
        alignItems: "center",
      }}
    >
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
              {...register("name", { required: "Name is required" })}
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
              {...register("model", { required: "Model is required" })}
              error={!!errors.model}
              helperText={errors?.model?.message as string}
            />
          </Grid>
          <Grid item xs={12} sm={12}>
            <AppTextInput
              control={control}
              name="starship_class"
              label="Starship Class"
            />
          </Grid>
          <Grid item xs={12} sm={12}>
            <AppTextInput
              control={control}
              name="manufacturer"
              label="Manufacturer"
            />
          </Grid>
          <Grid item xs={12} sm={6}>
            <AppTextInput
              control={control}
              name="cost_in_credits"
              label="Cost In Credits"
            />
          </Grid>
          <Grid item xs={12} sm={6}>
            <AppTextInput control={control} name="length" label="Length" />
          </Grid>
          <Grid item xs={12} sm={6}>
            <AppTextInput
              control={control}
              name="max_atmosphering_speed"
              label="Max Atmoshering Speed"
            />
          </Grid>
          <Grid item xs={12} sm={6}>
            <AppTextInput control={control} name="crew" label="Crew" />
          </Grid>
          <Grid item xs={12} sm={6}>
            <AppTextInput
              control={control}
              name="passengers"
              label="Passengers"
            />
          </Grid>
          <Grid item xs={12} sm={6}>
            <AppTextInput
              control={control}
              name="cargo_capacity"
              label="Cargo Capacity"
            />
          </Grid>
          <Grid item xs={12} sm={6}>
            <AppTextInput
              control={control}
              name="consumerables"
              label="Consumerables"
            />
          </Grid>
          <Grid item xs={12} sm={6}>
            <AppTextInput
              control={control}
              name="hyperdrive_rating"
              label="Hyperdrive Rating"
            />
          </Grid>
          <Grid item xs={12} sm={6}>
            <AppTextInput control={control} name="MGLT" label="MGLT" />
          </Grid>
          <Grid item xs={12} sm={6}>
            <FormLabel component="legend">Films</FormLabel>
            <AppCheckboxGroup
              items={films}
              checked={starship?.films}
              onChange={(checkedItems: Film[]) => {
                console.log(checkedItems);
                setFilmIds(checkedItems.map((f) => f.film_id));
              }}
            />
          </Grid>

          <Grid item xs={12}>
            <Box
              display="flex"
              justifyContent="space-between"
              alignItems="center"
            >
              <AppDropzone control={control} name="file" />
              {watchFile ? (
                <img
                  src={watchFile.preview}
                  alt="preview"
                  style={{ maxHeight: 200 }}
                />
              ) : (
                <img
                  src={starship?.image}
                  alt={starship?.name}
                  style={{ maxHeight: 200 }}
                />
              )}
            </Box>
          </Grid>
        </Grid>
        <Box display="flex" justifyContent="space-between">
          <Button
            onClick={cancelEdit}
            variant="contained"
            color="inherit"
            sx={{ mt: 3, mb: 2 }}
          >
            Cancel
          </Button>
          <LoadingButton
            disabled={!isValid}
            loading={isSubmitting}
            type="submit"
            variant="contained"
            sx={{ mt: 3, mb: 2 }}
          >
            Save
          </LoadingButton>
        </Box>
      </form>
    </Container>
  );
}
