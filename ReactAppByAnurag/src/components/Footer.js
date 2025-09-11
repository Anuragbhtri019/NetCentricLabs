import React from "react";
import "./Footer.css";

function Footer() {
  const year = new Date().getFullYear();

  return (
    <footer className="footer">
      <p>© Anurag Bhattarai, {year}</p>
    </footer>
  );
}

export default Footer;
