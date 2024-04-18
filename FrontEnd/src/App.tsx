import { SelectedOptionsContextProvider } from './Context/SelectedOptionsContext';
import Home from './Pages/Home'; // Example component for Home page
import Read from './Pages/Read'; // Example component for Read page

import {
  createBrowserRouter,
  RouterProvider,
} from "react-router-dom";

const router = createBrowserRouter([
  {
    path: "/",
    element: (
      <Home />
    ),
  },
  {
    path: "read",
    element: (
      <Read />
    ),
  },
]);

function App() {
  return (
    <SelectedOptionsContextProvider>
      <RouterProvider router={router} />
    </SelectedOptionsContextProvider>
  );
}

export default App;