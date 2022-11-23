/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./Views/**/*.cshtml"],
  theme: {
    fontSize: {
      sm: '0.8rem',
      base: '1rem',
      xl: '1.25rem',
      '2xl': '1.563rem',
      '3xl': '1.953rem',
      '4xl': '2.441rem',
      '6xl': ['1.875rem', {
        lineHeight: '2.25rem',
        letterSpacing: '-0.02em',
        fontWeight: '700',
      }],
      '8xl': ['1.875rem', {
        lineHeight: '2.25rem',
        letterSpacing: '-0.02em',
        fontWeight: '700',
      }],
    },
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
