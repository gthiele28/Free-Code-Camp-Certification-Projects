const inputContainer = document.getElementById("input-container");
const getWeatherBtn = document.getElementById("get-weather-btn");
const locationSelector = document.getElementById("location-selector");

const weatherCard = document.getElementById("weather-card");
const weatherIcon = document.getElementById("weather-icon");
const mainTemperature = document.getElementById("main-temperature");
const feelsLike = document.getElementById("feels-like");
const humidity = document.getElementById("humidity");
const wind = document.getElementById("wind");
const windGust = document.getElementById("wind-gust");
const weatherMain = document.getElementById("weather-main");
const loc = document.getElementById("location");


async function getWeather(city) {
  try {
    const response = await fetch(
      `https://weather-proxy.freecodecamp.rocks/api/city/${encodeURIComponent(city)}`
    );

     if (!response.ok) {
       throw new Error(`HTTP error! status: ${response.status}`);
    }

    const data = await response.json();
    return data;
  } catch (err) {
    console.log(err.message);
  }
}

async function showWeather (city) {
  try {
    const cityWeather = await getWeather(city);

    //Image display
    if (cityWeather.weather[0].icon === undefined) {
      weatherIcon.src = "corrupt";
      weatherIcon.alt = "N/A";
    } else {
      weatherIcon.src = cityWeather.weather[0].icon;
      weatherIcon.alt = "weather icon image";
    }

    //main temperature display
    tryDisplay(mainTemperature, cityWeather.main.temp);

    //feels like display
    tryDisplay(feelsLike, cityWeather.main.feels_like);

    //humidity display
    tryDisplay(humidity, cityWeather.main.humidity);

    //wind display
    tryDisplay(wind, cityWeather.wind.speed);

    //wind-gust display
    tryDisplay(windGust, cityWeather.wind.gust);

    //weather-main
    tryDisplay(weatherMain, cityWeather.weather[0].main);

    //location
    tryDisplay(loc, cityWeather.name);

  } catch (err) {
    alert("Something went wrong, please try again later");
    weatherIcon.src = "corrupt";
    weatherIcon.alt = "N/A";
    mainTemperature.textContent = "N/A";
    feelsLike.textContent = "N/A";
    humidity.textContent = "N/A";
    wind.textContent = "N/A";
    windGust.textContent = "N/A";
    weatherMain.textContent = "N/A";
    location.textContent = "N/A";
  }
}

function tryDisplay (element, value) {
  if (value === undefined) {
    element.textContent = "N/A";
  } else {
    element.textContent = value;
  }
}

getWeatherBtn.addEventListener("click", () => {
  const city = locationSelector.value;
  
  if (city === "") {
    return;
  } else {
    showWeather(city);
    return;
  }
});