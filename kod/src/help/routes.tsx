import AboutUs from "@/pages/AboutUs"
import Clicker from "@/pages/Clicker"
import Contact from "@/pages/Contact"
import Home from "@/pages/Home"

interface Routes{
    path:string
    element:JSX.Element
    title:string
}
export const routes:Routes[] = [
    {
        path:"/",
        element:<Home/>,
        title:"home"
    },
    {
        path:"/about-us",
        element:<AboutUs/>,
        title:"about-us"
    },
    {
        path:"/contact",
        element:<Contact/>,
        title:"contact"
    },
    {
        path:"/clicker",
        element:<Clicker/>,
        title:"clicker"
    }
]