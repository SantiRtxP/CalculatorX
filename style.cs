body {
    font-family: 'Segoe UI', Arial, sans-serif;
    background-color: #f0f2f5;
    margin: 0;
    padding: 20px;
    display: flex;
    justify-content: center;
    align-items: center;
    min-height: 100vh;
}

.container {
    background-color: white;
    padding: 25px;
    border-radius: 15px;
    box-shadow: 0 4px 15px rgba(0,0,0,0.1);
    width: 100%;
    max-width: 400px;
    box-sizing: border-box;
}

h1 {
    text-align: center;
    color: #333;
    margin-top: 0;
}

.form-group {
    margin-bottom: 20px;
}

label {
    display: block;
    margin-bottom: 8px;
    font-weight: bold;
    color: #555;
}

input {
    width: 100%;
    padding: 12px;
    border: 2px solid #ddd;
    border-radius: 8px;
    font-size: 16px;
    box-sizing: border-box;
}

button {
    width: 100%;
    background-color: #25d366;
    color: white;
    border: none;
    padding: 14px;
    font-size: 16px;
    font-weight: bold;
    border-radius: 8px;
    cursor: pointer;
    transition: background 0.3s;
}

button:hover {
    background-color: #128c7e;
}

.result-box {
    margin-top: 20px;
    padding: 15px;
    border-radius: 8px;
    font-size: 16px;
}

.hidden {
    display: none;
}

.positivo {
    background-color: #d4edda;
    color: #155724;
    border: 1px solid #c3e6cb;
}

.negativo {
    background-color: #f8d7da;
    color: #721c24;
    border: 1px solid #f5c6cb;
}
