import '../styles/globals.sass'
import '../styles/login.sass'
import '../styles/map.sass'
import '../styles/index.sass'
import '../styles/companies/new.sass'
import '../styles/signUp.sass'
import '../styles/establishmentInfo.sass'
import '../components/sideMenu.sass'
import type { AppProps } from 'next/app'

export default function App({ Component, pageProps }: AppProps) {
  return <Component {...pageProps} />
}
