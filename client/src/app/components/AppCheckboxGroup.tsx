import { FormGroup, FormControlLabel, Checkbox } from "@mui/material";
import { useState } from "react";
import { Film, FilmDto } from "../models/film";

interface Props {
  items: FilmDto[];
  checked?: Film[];
  onChange: (items: Film[]) => void;
}

export default function CheckboxButtons({ items, checked, onChange }: Props) {
  const [checkedItems, setCheckedItems] = useState(checked || []);

  function handleChecked(value: FilmDto) {
    const found: boolean = checkedItems.some((item) => item.film_id === value.id);
    let newChecked: Film[] = [];

    if (!found)  {
        const newValue: Film = { ...value, film_id: value.id };
        newChecked = [...checkedItems, newValue];
    }
    else newChecked = checkedItems.filter((i) => i.film_id !== value.id);
    setCheckedItems(newChecked);
    onChange(newChecked);
  }

  return (
    <FormGroup row={true}>
      {items.map((item) => (
        <FormControlLabel
          key={item.id}
          control={
            <Checkbox
              checked={checkedItems.some((i) => i.film_id === item.id)}
              onClick={() => handleChecked(item)}
              size="small"
            />
          }
          label={`E${item.episode_id}`}
        />
      ))}
    </FormGroup>
  );
}
