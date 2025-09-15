import React, { useState } from "react";

function Calculator() {
    const [num1, setNum1] = useState("");
    const [num2, setNum2] = useState("");
    const [operation, setOperation] = useState("add");
    const [result, setResult] = useState(null);

    const handleCompute = () => {
        const a = parseFloat(num1);
        const b = parseFloat(num2);
        if (isNaN(a) || isNaN(b)) {
            setResult("Please enter valid numbers!");
            return;
        }
        let res;
        if (operation === "add") res = a + b;
        if (operation === "subtract") res = a - b;
        if (operation === "multiply") res = a * b;
        setResult(res);
    };

    return (
        <div className="calculator">
            <h2>Calculator</h2>
            <input
                type="number"
                placeholder="Enter first number"
                value={num1}
                onChange={(e) => setNum1(e.target.value)}
            />
            <input
                type="number"
                placeholder="Enter second number"
                value={num2}
                onChange={(e) => setNum2(e.target.value)}
            />
            <select value={operation} onChange={(e) => setOperation(e.target.value)}>
                <option value="add">Add</option>
                <option value="subtract">Subtract</option>
                <option value="multiply">Multiply</option>
            </select>
            <button onClick={handleCompute}>Compute</button>
            {result !== null && <p className="result">Result: {result}</p>}

            <style>{`
        .calculator {
          max-width: 300px;
          margin: 40px auto;
          padding: 20px;
          border: 1px solid #ddd;
          border-radius: 10px;
          background: #f9f9f9;
          text-align: center;
        }

        .calculator h2 {
          margin-bottom: 16px;
        }

        .calculator input,
        .calculator select,
        .calculator button {
          padding: 6px 10px;
          font-size: 0.9rem;
          height: 40px;
          width: 90%;
          margin-bottom: 10px;
          border: 1px solid #ccc;
          border-radius: 2px;
        }

        .calculator button {
          background-color: #1976d2;
          color: white;
          border: none;
          cursor: pointer;
          font-weight: bold;
        }

        .calculator button:hover {
          background-color: #1565c0;
        }

        .result {
          margin-top: 12px;
          font-size: 1rem;
          font-weight: bold;
        }
      `}</style>
        </div>
    );
}

export default Calculator;
