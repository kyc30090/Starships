import { Box, Typography, Card, CardHeader, Avatar, Stack } from "@mui/material";
import { useState, useEffect } from "react";
import agent from "../app/api/agent";
import { Person } from "../app/models/person";

function stringToColor(string: string) {
    let hash = 0;
    let i;

    /* eslint-disable no-bitwise */
    for (i = 0; i < string.length; i += 1) {
        hash = string.charCodeAt(i) + ((hash << 5) - hash);
    }

    let color = '#';

    for (i = 0; i < 3; i += 1) {
        const value = (hash >> (i * 8)) & 0xff;
        color += `00${value.toString(16)}`.slice(-2);
    }
    /* eslint-enable no-bitwise */

    return color;
}

export function stringAvatar(name: string): any {
    let prefixes = name.split(' ')[0][0];
    if (name.split(' ')[1]) prefixes = `${name.split(' ')[0][0]}${name.split(' ')[1][0]}`;
    return {
        sx: {
            bgcolor: stringToColor(name),
        },
        children: prefixes
    };
}

export default function Pilots() {
    const [people, setPeople] = useState<Person[]>([]);
    const [loading, setLoading] = useState(true);

    useEffect(() => {
        agent.People.list()
            .then(response => setPeople(response))
            .catch(error => console.log(error))
            .finally(() => setLoading(false))
    }, []);

    if (loading) return (<h1>Loading...</h1>);

    return (<>
        <Box display='flex' justifyContent='space-between'>
            <Typography sx={{ p: 2 }} variant='h4'>People</Typography>
        </Box>
        <Stack>
            {people.map(person =>
            (<Card key={person.id} sx={{ minWidth: 275 }}>
                <CardHeader
                    avatar={
                        <Avatar {...stringAvatar(person.name)} />
                    }
                    title={person.name}
                    titleTypographyProps={{
                        sx: { fontWeight: 'bold', color: 'primary.main' }
                    }}
                />
            </Card>
            ))}
        </Stack>
    </>);
}