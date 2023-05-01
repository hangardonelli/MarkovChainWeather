# MarkovChainWeather
Brief demonstration of the usefulness of markov chains using weather as an example

A Markov chain is a stochastic model used to describe the evolution of a system over time. An example of a Markov chain could be the following:

Suppose we want to model the weather in a city. We could define three possible states for the weather: "sunny", "cloudy" and "rainy". We could then collect data on the weather in the city over several days and use that data to build a transition matrix that describes the probabilities of moving from one state to another.

For example, suppose our transition matrix looks like this:

|        | Sunny | Cloudy | Rainy |
|--------|-------|--------|-------|
| Sunny  | 0.6   | 0.2    | 0.2   |
| Cloudy | 0.4   | 0.4    | 0.2   |
| Rainy  | 0.2   | 0.4    | 0.4   |

This transition matrix means that if the weather is sunny today, there is a 60% chance that tomorrow will also be sunny, a 30% chance that it will be cloudy, and a 10% chance that it will be rainy. Similarly, if the weather is cloudy today, there is a 40% chance that tomorrow will be sunny, a 40% chance that it will be cloudy, and a 20% chance that it will be rainy.



To simulate the weather in the city using the Markov chain that we have defined, the following steps can be followed:

 1. Define the initial state: we choose one of the possible states
    (sunny, cloudy or rainy) as the initial state. For example, we could
    start with the "sunny" state.
2. Using the transition matrix to calculate the transition
    probabilities: We multiply the probability vector of the current
    state (in the first step, this would be the probability vector for
    the "sunny" state) by the transition matrix to obtain the
    probability vector of the next state.
    
3. Repeat step 2 several times: After getting the probability vector
    for the next state, we use it as the current probability vector and
    repeat step 2 to get the probability vector for the next state. We
    can repeat this step as many times as we want to simulate the
    weather in the city during a certain period of time.


In other words, we have the following chain:


![Markov Chain Example](https://i.ibb.co/9rNNXGQ/3estados.png)

Since in the example we are giving a weekly forecast, the chain is equivalent to the following sequence

![Markov Chain Example](https://latex2png.com/pngs/9238be29f0e8e5842054e2e793e677ec.png)

That may be reduced to:


![Markov Chain Example](https://i.ibb.co/Sw1KLmS/gif.gif)


