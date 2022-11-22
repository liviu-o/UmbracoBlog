/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./Views/**/*.cshtml"],
  theme: {
    screens: {
      sm: '480px',
      md: '768px',
      lg: '976px',
      xl: '1440px',
    },
    extend: {
      fontFamily: {
        sans: ['Roboto Condensed','Open sans','Helvetica','Arial', 'sans-serif'],
        alata: ['Alata'],
      },
      letterSpacing: {
        widest: '.3em',
      },
      colors: {
        primary: '#00566b',
        secondary: '#296578',
        border: 'rgba(255,255,255,.3)',
        purple: '#45235e',
      },
      backgroundImage: {
        'hero': "url('../src/images/bg.jpg')",
      },
    },
  },
  plugins: [],
}
