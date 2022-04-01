import { useUser } from '@auth0/nextjs-auth0';
import Link from 'next/link'
import Layout from '../components/Layout'

const IndexPage = () => {
  const { user } = useUser();

  return (
    <Layout title="Home | webflix">
        <h1>Hello {user?.email}</h1>
    </Layout>
  );
}

export default IndexPage
