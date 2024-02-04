import { routes } from '@/help/routes';
import './navbar.scss'
import {Link} from "react-router-dom";
import { title } from 'process';

export default function Navbar() {
  return (
    <div id="app-nav">
      <div className="navbar-brand">
        App name
      </div>
      <nav>
        <ul className="navbar-nav">
          
            
            {routes.map(route=>(
                <li className="nav-item">
                  <Link to={route.path} key={route.path} className="nav-link">{route.title}</Link>
                </li>
            ))}
          
        </ul>
      </nav>
    </div>
  )
}