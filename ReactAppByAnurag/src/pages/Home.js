import React from "react";
import "./Home.css";
import anuragImg from "../assets/anurag.webp";

function Home() {
  return (
    <div className="home">
      <h2>Welcome to ReactAppByAnurag </h2>
      <p>This is the home page of React app.</p>
      <img src={anuragImg} alt="Anurag" className="home-image" />
    </div>
  );
}

export default Home;
