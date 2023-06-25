import { debounce, TextField } from "@mui/material";
import { useState } from "react";
import { useAppDispatch, useAppSelector } from "../app/store/configureStore";
import { setShipParams } from "./catalogSlice";

export default function ShipSearch() {
    const { shipParams } = useAppSelector(state => state.catalog);
    const [searchTerm, setSearchTerm] = useState(shipParams.searchTerm);
    const dispatch = useAppDispatch();

    const debouncedSearch = debounce((event: any) => {
        dispatch(setShipParams({ searchTerm: event.target.value }))
    }, 1000)

    return (
        <TextField
            label='Search starships'
            variant='outlined'
            fullWidth
            value={searchTerm || ''}
            onChange={(event: any) => {
                setSearchTerm(event.target.value);
                debouncedSearch(event);
            }}
        />
    )
}