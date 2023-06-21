import { Home } from "@mui/icons-material";
import { AppBar, IconButton, List, ListItem, Toolbar, Typography } from "@mui/material";
import { NavLink } from "react-router-dom";

interface Props {
    handleThemeChange: () => void;
}

const links = [
    { title: 'starships', path: '/starships' },
    { title: 'films', path: '/films' },
    { title: 'pilots', path: '/pilots' }
];
const navStyles = {
    color: 'inherit',
    textDecoration: 'none',
    typography: 'h6',
    '&:hover': {
        color: 'grey.500'
    },
    '&.active': {
        color: 'text.secondary'
    }
}
export default function Header() {
    return (
        <AppBar position='static' sx={{ mb: 4 }}>
            <Toolbar sx={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center' }}>
                <IconButton color="primary" aria-label="home" component={NavLink}
                        to='/' >
                    <Home />
                </IconButton>
                
                <List sx={{ display: 'flex' }}>
                    {links.map(({ title, path }) => (
                        <ListItem
                            component={NavLink}
                            to={path}
                            key={path}
                            sx={navStyles}>
                            {title.toUpperCase()}
                        </ListItem>
                    ))}
                </List>
            </Toolbar>
        </AppBar>
    );
}