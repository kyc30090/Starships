import { Container, CssBaseline, ThemeProvider, Typography, createTheme } from '@mui/material';
import Header from './Header';
import { Outlet } from 'react-router-dom';
import { yellow } from '@mui/material/colors';


function App() {
  const theme = createTheme({
    palette: {
      mode: 'dark',
      text: {
        primary: yellow[500],
        secondary: '#fff',
      }
    },
    
  })
  return (
    <ThemeProvider theme={theme}>
       <CssBaseline />
       <Header />
       <Container>
         <Outlet />
       </Container>
    </ThemeProvider>
  );
}

export default App;
