import { UserProvider } from "@auth0/nextjs-auth0";
import { AppProps } from "next/app";

const MyApp = ({ Component, pageProps }: AppProps): JSX.Element => {
    return (
        <UserProvider>
            <Component {...pageProps} />
        </UserProvider>
    );
}

export default MyApp;