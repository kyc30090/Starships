import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import DetailTemplate from "./DetailTemplate";
import agent from "../app/api/agent";
import { useAppDispatch, useAppSelector } from "../app/store/configureStore";
import { fetchShipAsync, starshipSelectors } from "./catalogSlice";

export default function ShipDetails() {
    const { id } = useParams<{ id: string }>();
    const dispatch = useAppDispatch();
    const starship = useAppSelector(state => starshipSelectors.selectById(state, id!));
    const { status } = useAppSelector(state => state.catalog );

    useEffect(() => {
        if (!starship) dispatch(fetchShipAsync(parseInt(id!)));
    }, [id, dispatch, starship]);

    const loading = status.includes('pending');

    return (<DetailTemplate loading={loading} starship={starship!} />);

}