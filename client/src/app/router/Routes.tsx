import { createBrowserRouter } from "react-router-dom";
import Films from "../../features/Films";
import Pilots from "../../features/Pilots";
import Catalog from "../../features/Catalog";
import ShipDetails from "../../features/ShipDetails";
import HomePage from "../../features/HomePage";
import App from "../layout/App";

export const router = createBrowserRouter([
    {
        path: '/',
        element: <App />,
        children: [
            { path: '', element: <HomePage /> },
            { path: 'starships', element: <Catalog /> },
            { path: 'starships/:id', element: <ShipDetails /> },
            { path: 'films', element: <Films /> },
            { path: 'pilots', element: <Pilots /> }
        ]
    }
]);
