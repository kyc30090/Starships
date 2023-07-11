export interface Film {
  film_id: number;
  title: string;
  episode_id: number;
  opening_crawl?: string;
  url?: string;
}

export interface FilmDto {
  id: number;
  title: string;
  episode_id: number;
  opening_crawl?: string;
  url?: string;
}