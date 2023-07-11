import {
  Box,
  Typography,
  Card,
  CardHeader,
  Avatar,
  CardContent,
} from "@mui/material";
import { useState, useEffect } from "react";
import { Film } from "../app/models/film";
import agent from "../app/api/agent";

export default function Films() {
  const [films, setFilms] = useState<Film[]>([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    agent.Films.list()
      .then((response) => setFilms(response))
      .catch((error) => console.log(error))
      .finally(() => setLoading(false));
  }, []);

  if (loading) return <h1>Loading...</h1>;

  return (
    <>
      <Box display="flex" justifyContent="space-between">
        <Typography sx={{ p: 2 }} variant="h4">
          Episodes
        </Typography>
      </Box>
      {films.map((film) => (
        <Card key={film.film_id} sx={{ minWidth: 275 }}>
          <CardHeader
            avatar={
              <Avatar sx={{ bgcolor: "secondary.main" }}>
                {film.episode_id}
              </Avatar>
            }
            title={film.title}
            titleTypographyProps={{
              sx: { fontWeight: "bold", color: "primary.main" },
            }}
          />
          <CardContent>
            <Typography
              sx={{ fontSize: 14 }}
              color="text.secondary"
              gutterBottom
            >
              {film.opening_crawl}
            </Typography>
          </CardContent>
        </Card>
      ))}
    </>
  );
}
