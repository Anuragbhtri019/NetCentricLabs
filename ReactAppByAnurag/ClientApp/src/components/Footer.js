import React from 'react';

function Footer() {
    const currentYear = new Date().getFullYear();
    return (
        <footer style={{
            borderTop: '1px solid #eee',
            background: '#eee',
            padding: '10px',
            textAlign: 'center',
            marginTop: '150px',
            fontFamily: 'var(--inter-font)',
            fontSize: '1rem',
            fontStyle: 'normal',
            fontWeight: 500,
            lineHeight: '1.5rem',
            letterSpacing: '-0.01125rem',
            color: 'var(--gray-700)'
        }}>
            {"\u00A9"} Anurag Bhattarai, {currentYear}
        </footer>
    );
}

export default Footer;
