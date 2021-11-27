const colors = require('tailwindcss/colors');
module.exports = {
    purge: {
        enabled: true,
        content: [
            './**/*.html',
            './**/*.razor'
        ],
    },
    darkMode: false,
    variants: {
        extend: {
            animation: ['motion-safe'],
            transitionProperty: ['responsive', 'motion-safe', 'motion-reduce'],
            divideColor: ['group-hover'],
        },
    },
    plugins: [],
}