
# ProfitChartBot

The main motivation for these project is the lack of an affordable api from nelogica in order to receive real time quotes from B3 exchange and then route orders to the exchange.

It works by scraping and doing an Screen OCR of the ProfitChart screen as we can see below and then sending the clicks via windows API to the buy / sell / close buttons

![Screen Scraping](./Scraping.png)

We can see above that the system will scrap the screen, get the quotes, then will send to the ML Model hosted by the [pyAutoTradingBot](https://github.com/gbencke/pyAutoTradingBot) API and it will return a score that will determine a long short position. In case of a signal, it will send a click to the desktop interface.

# Configuration

In order for the system to work properly, it is necessary to configure it. Please click in the configuration menu item in the system menu to display the configuration window:

![Configuration](./configuration.png)

* **Indicators Region**: The region in the screen where the indicators are located, and we will try to scrap them
* **Start Long Region**: The Buy Button coordinates in ProfitChart
* **Start Short Region**: The Sell Button coordinates in ProfitChart
* **Close Positions**: The Close Positions Button coordinates in ProfitChart
* **Tesseract Executable**: The tesseract exe location
* **Tessdata Location**: The Tessdata that contains the OCR Model.
* **GET Parameters URL**: The URL for the GetParameters Endpoint
* **POST Quote URL**: The URL for the Post OHLC Quote Endpoint
* **GET Prediction URL**: The URL for the GetPrediction URL
* **Text Log Dir**: A Directory for the Bot Log
* **Image Log Dir**: A Directory for the screenshots taken for the tesseract OCR Process
* **Profit Scan Interval**: The interval in ms for the Profit Scan.

```diff
- This repo is deprecated, 
- as Nelogica has a new realtime quote / order routing API that is very affordable, 
- I strongly suggest using it instead of this project.
```
