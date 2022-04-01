import { useRouter } from "next/router";
import { useState, useEffect, ReactNode } from "react";
import UserStore from './stores/userStore';

interface IProps {
    children: ReactNode
}

const RouteGruard = (props: IProps) => {
    const router = useRouter();
    const [authorized, setAuthorized] = useState(false);

    useEffect(() => {
        authCheck(router.asPath);

        const hideContent = () => setAuthorized(false);

        router.events.on('routeChangeStart', hideContent);
        router.events.on('routeChangeComplete', authCheck);

        return () => {
            router.events.off('routeChangeStart', hideContent);
            router.events.off('routeChangeComplete', authCheck);
        }
    }, []);

    const authCheck = (url: string) => {
        const publicPaths = ['/api/auth.login'];
        const path = url.split('?')[0];
    
        const userStore = new UserStore();

        if (!userStore.user && !publicPaths.includes(path)) {
            setAuthorized(false);

            router.push({
                pathname: '/login',
                query: { returnUrl: router.asPath }
            });
        } else {
            setAuthorized(true);
        }
    }

    return (authorized && props.children);
}

export default RouteGruard;