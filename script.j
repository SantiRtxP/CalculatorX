function calcularPresupuesto() {
    const ingresos = parseFloat(document.getElementById('ingresos').value) || 0;
    const gastos = parseFloat(document.getElementById('gastos').value) || 0;
    const resultadoDiv = document.getElementById('resultado');
    const msgBalance = document.getElementById('mensaje-balance');
    const msgAhorro = document.getElementById('mensaje-ahorro');

    // Validación simple
    if (ingresos === 0 && gastos === 0) {
        alert("Por favor, introduce algún monto.");
        return;
    }

    const balance = ingresos - gastos;
    resultadoDiv.classList.remove('hidden');

    if (balance >= 0) {
        resultadoDiv.className = "result-box positivo";
        msgBalance.innerHTML = `<strong>Balance disponible:</strong> $${balance.toFixed(2)}`;
        
        // Calcular porcentaje de ahorro
        const porcentaje = ingresos > 0 ? ((balance / ingresos) * 100).toFixed(0) : 0;
        msgAhorro.innerHTML = `🎉 ¡Vas bien! Estás logrando guardar el <strong>${porcentaje}%</strong> de tus ingresos.`;
    } else {
        resultadoDiv.className = "result-box negativo";
        msgBalance.innerHTML = `<strong>Déficit financiero:</strong> $${Math.abs(balance).toFixed(2)}`;
        msgAhorro.innerHTML = `⚠️ Alerta: Tus gastos superan tus ingresos por $${Math.abs(balance).toFixed(2)}. Revisa tus cuentas.`;
    }
}
