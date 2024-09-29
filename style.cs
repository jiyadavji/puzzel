body {
    display: flex;
    flex-direction: column;
    align-items: center;
    font-family: 'Roboto', sans-serif;
    background-color: #e8f5e9;
    margin: 0;
    padding: 20px;
}

h1 {
    margin-bottom: 20px;
    color: #004d40;
}

#puzzleGrid {
    display: grid;
    gap: 10px;
    margin-top: 20px;
    background-color: #c8e6c9;
    padding: 10px;
    border-radius: 10px;
}

.cell {
    width: 65px;
    height: 65px;
    display: flex;
    justify-content: center;
    align-items: center;
    background-color: #a5d6a7;
    font-size: 22px;
    border: 2px solid #004d40;
    border-radius: 10px;
    transition: background-color 0.3s ease, transform 0.2s ease;
}

.cell:hover {
    background-color: #81c784;
    transform: scale(1.05);
}

.blank {
    background-color: #eeeeee;
}

button {
    margin: 12px;
    padding: 12px 20px;
    font-size: 18px;
    cursor: pointer;
    background-color: #004d40;
    color: white;
    border: none;
    border-radius: 8px;
    transition: background-color 0.3s ease, transform 0.2s ease;
    box-shadow: 0 2px 4px rgba(0, 0, 0, 0.2);
}

button:hover {
    background-color: #00251a;
    transform: scale(1.05);
}

#solutionContainer {
    display: grid;
    grid-template-columns: repeat(4, 1fr); /* Display 4 matrices per row */
    gap: 25px; /* Padding between matrices */
    margin-top: 25px; /* Padding above the solution container */
}

.matrix {
    display: grid;
    grid-template-columns: repeat(${size}, 65px); /* Adjust for matrix size */
    gap: 10px; /* Space between cells in the matrix */
    padding: 10px; /* Padding around each matrix */
    background-color: #f0f4c3; /* Light color for the matrix background */
    border:2px solid #00796b; /* Border around the matrix */
    border-radius: 10px; /* Rounded corners for a softer look */
    text-align: center; /* Center align text in matrix */
}

.stepLabel {
    text-align: center;
    font-weight: bold;
    margin-bottom: 10px; /* Space between label and matrix */
    grid-column: span 4; /* Make label span across all 4 columns */
}
