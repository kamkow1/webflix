import React, { ReactNode } from 'react'
import Link from 'next/link'
import Head from 'next/head'
import NavBar from './navbar/NavBar'

type Props = {
  children?: ReactNode
  title?: string
}

const Layout = ({ children, title = 'This is the default title' }: Props): JSX.Element => {
  return (
    <div>
        <Head>
          <title>{title}</title>
          <meta charSet="utf-8" />
          <meta name="viewport" content="initial-scale=1.0, width=device-width" />
          <link rel="stylesheet" href="/static/styles/NavBar.css" />
        </Head>
        <NavBar />
        {children}
    </div>
  );
}

export default Layout
