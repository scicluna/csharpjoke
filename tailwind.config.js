/** @type {import('tailwindcss').Config} */
module.exports = {
  purge: {
    content: [
      './**/*.html',
      './**/*.cshtml',
    ],
    options: {
      safelist: [],  // Specify a safelist of classes that should not be purged
    },
  },
  content: [],
  theme: {
    extend: {},
  },
  plugins: [],
}

