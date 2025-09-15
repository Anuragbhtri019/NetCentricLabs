import React from 'react';
import { Link } from 'react-router-dom';

function Navbar() {
    return (
        <nav style={{
            background: '#1976d2',
            padding: '10px',
            color: 'white',
            display: 'flex',
            alignItems: 'center',
            justifyContent: 'space-between',
            fontFamily: 'var(--inter-font)'
        }}>
            <h2 style={{ margin: 0, color: 'white' }}>ReactAppByAnurag</h2>
            <div>
                <Link to="/" style={{ marginRight: '15px', color: 'white', textDecoration: 'none' }}>Home</Link>
                <Link to="/calculator" style={{ color: 'white', textDecoration: 'none' }}>Calculator</Link>
            </div>

            <style>{`
        nav a {
          font-size: 1rem;
          font-style: normal;
          font-weight: 500;
          line-height: 1.5rem;
          letter-spacing: -0.01125rem;
          color: white;
          transition: color 0.3s ease;
        }
      `}</style>
        </nav>
    );
}

export default Navbar;
