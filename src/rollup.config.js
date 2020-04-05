import resolve from "rollup-plugin-node-resolve";
import { terser } from "rollup-plugin-terser";

process.env.INCLUDE_DEPS === "true";
module.exports = {
  input: "Prism/Scripts/Prism.js",
  output: {
    file: "artifacts/Prism.js",
    format: "iife"
  },
  plugins: [resolve(), terser()]
};
