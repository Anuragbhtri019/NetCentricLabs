import React from 'react';
import homeImage from '../assets/anurag.webp'; // Make sure the image exists here

function Home() {
    return (
        <div className="home">
            <h2>Welcome to ReactAppByAnurag</h2>
            <img
                src={homeImage}
                alt="Home"
                className="home-image"
            />

            <style>{`
        .home {
          text-align: center;
          padding: 30px;
        }

        .home-image {
          margin-top: 20px;
          width: 80%;
          max-width: 500px;
          border-radius: 12px;
          box-shadow: 0 4px 10px rgba(0, 0, 0, 0.2);
        }

        .home h2 {
          color: #333;
        }

        @media (max-width: 600px) {
          .home-image {
            width: 100%;
          }
        }
      `}</style>
        </div>
    );
}

export default Home;
