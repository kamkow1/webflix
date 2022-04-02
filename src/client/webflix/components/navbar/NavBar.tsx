import { Navbar, Nav, NavItem, NavLink, NavbarBrand } from 'reactstrap'
import 'bootstrap/dist/css/bootstrap.min.css'
import { BsFilm } from 'react-icons/bs'
import { useUser } from '@auth0/nextjs-auth0'

const NavBar = (): JSX.Element => {
    const brandIcon = {
        marginRight: '10px'
    }

    const { user } = useUser();

    return (
        <div>
            <Navbar color="dark" dark expand="md">
                <Nav className="mr-auto" navbar>
                    <NavbarBrand href="/">
                        <BsFilm style={brandIcon} />
                        webflix
                        </NavbarBrand>
                    <NavItem>
                        <NavLink href="/">home</NavLink>
                    </NavItem>
                    <NavItem>
                        <NavLink href="/api/auth/login">sign in</NavLink>
                    </NavItem>
                    {user && 
                        <NavItem>
                            <NavLink href="/api/auth/logout">sign out</NavLink>
                        </NavItem>
                    }
                </Nav>
            </Navbar>
        </div>
    );
}

export default NavBar;