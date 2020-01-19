import resolve from "rollup-plugin-node-resolve";
//import { terser } from "rollup-plugin-terser";

process.env.INCLUDE_DEPS === "true";
module.exports = {
  input: "Prisma/Scripts/Prisma.js",
  output: {
    file: "wwwroot/Prisma.js",
    format: "iife"
  },
  plugins: [resolve()]//, terser()]
};
