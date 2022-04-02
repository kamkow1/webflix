import { UserProvider, useUser } from "@auth0/nextjs-auth0";
import { AppProps } from "next/app";
import User from "../utils/models/User";
import UserStore from "../utils/stores/userStore";

const MyApp = ({ Component, pageProps }: AppProps): JSX.Element => {
    return (
        <UserProvider>
            <Component {...pageProps} />
        </UserProvider>
    );
}

export default MyApp;