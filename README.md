# Crypto Bot

Crear un CryptoBot que utilice un algoritmo de predicción para tomar decisiones de compra y venta de diferente tipos de criptomonedas.

Utilizar una API de valores históricos de criptomonedas para poder utilizar información histórica para crear un Bot que haga compra y venta basada en un modelo probabilístico.

## Objetivos

- Obtener información de los precios de Bitcoin históricos de una API.
    - Binance, Coinbase o Kraken.
- Elegir un monto con el cual el bot comienza a comprar y vender.
- Definir el parámetro de riesgo del bot.
- Crear un bot que compre y venda Bitcoin basada en información historica.
    - Esto debe de venir de un algoritmo que utilice los cambios de los días previos para saber si debe de comprar o vender.
- Obtener el valor actual de Bitcoin a USD para hacer la conversión al momento de hacer una compra o venta.
- Mantener un registro en una base de datos de las decisiones que tomo el bot.
- Mantener un registro en una base de datos de los resultados diarios de el bot.
    - Con cuánto dinero comenzó el día y con cuanto termino.
- Responder la pregunta de: ¿Cuánto dinero ha hecho/perdido el bot hasta hoy?
