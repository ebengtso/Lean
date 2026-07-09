# SPX500 IB Trend Scalper Analysis

- Metrics file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_012/execution-metrics.csv`
- Backtest file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_012/launcher/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm.json`
- Completed paired trades: 110
- Entry signals: 110
- Approx open/unpaired entry signals: 0
- Position/order maintenance waits: 7428
- Total paired trade PnL: 5835.20
- Win rate: 94.5%
- Realized loss trades: 6
- Median hold: 12.0 minutes
- Average hold: 17.6 minutes

## Lean Runtime Statistics
- Equity: $105,835.20
- Net Profit: $5,835.20
- Return: 5.84 %
- Probabilistic Sharpe Ratio: 100.000%
- Volume: $46,885,697.40

## Risk And Efficiency
- Exposure hours: 32.2
- PnL per exposure hour: 181.27
- Calendar span days: 12.3
- PnL per calendar day: 473.73
- Trades per calendar day: 8.93
- Exposure share of calendar time: 10.9%
- Growth quality score: 901.2
- VIX stale at entry: 0.0%
- ES stale rows: 9.3%
- Waiting ES VWAP rows: 0.0%
- Trade-health exit signals: 0
- Trade-health tighten signals: 0
- Slow trades held >= 12 hours: 0 (0.0%)
- Slow exposure hours: 0.0
- Slow PnL per exposure hour: 
- Fast <15m trades: 66
- Fast PnL per exposure hour: 764.48

## Pullback Broken Structure Veto
- Blocked signal rows: 1336
- Blocked by profile: `{"charm_pin_pullback_long": 1284, "pullback_long": 52}`
- Blocked net profit / worst MAE: not available for hard-blocked signals because they do not become completed trades.
- Remaining trades by profile: `{"breakout_long_1dte": 20, "breakout_long_no_0dte": 3, "call_wall_acceptance_long": 1, "charm_pin_pullback_long": 36, "charm_wall_breakaway_long": 5, "pullback_long": 31, "pullback_long_no_0dte": 4, "squeeze_long": 10}`
- Remaining PnL by profile: `{"breakout_long_1dte": 1007.5999999999913, "breakout_long_no_0dte": 276.40000000001237, "call_wall_acceptance_long": 91.0, "charm_pin_pullback_long": 762.4000000001206, "charm_wall_breakaway_long": 517.5999999999876, "pullback_long": 2294.6000000001986, "pullback_long_no_0dte": 165.59999999998035, "squeeze_long": 720.0000000000064}`

## Lean Portfolio And Trade Statistics
- Portfolio: sharpeRatio=23.9674, sortinoRatio=0, alpha=0, beta=0, informationRatio=24.5973, drawdown=0.005
- Trades: sharpeRatio=0.7333, averageMAE=-94.2386, averageMFE=81.3673, largestMAE=-392.0, largestMFE=441.0, maximumIntraTradeDrawdown=-572.05

## Strategy Profile Performance

| Strategy | Enabled | Data State | Profile Set | Trades | PnL | Avg PnL | Win Rate | Median Hold Min | Exposure Hrs | PnL/Exposure Hr | Slow >=12h | Worst MAE | Median MFE | Median TP |
| --- | --- | --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| pullback_long | true | VALID_0DTE | VALID_0DTE | 31 | 2294.60 | 74.02 | 93.5% | 12.0 | 9.2 | 249.72 | 0 | -392.00 | 102.10 | 3.33 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 1007.60 | 50.38 | 95.0% | 14.1 | 7.0 | 143.76 | 0 | -375.70 | 79.88 | 3.00 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 36 | 762.40 | 21.18 | 94.4% | 6.1 | 6.2 | 122.68 | 0 | -212.50 | 40.80 | 2.40 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 10 | 720.00 | 72.00 | 100.0% | 15.7 | 3.9 | 186.91 | 0 | -208.25 | 77.78 | 33.59 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 5 | 517.60 | 103.52 | 80.0% | 16.0 | 2.6 | 202.54 | 0 | -346.80 | 146.20 | 12.00 |
| breakout_long_no_0dte | true | EXPIRED_0DTE | EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 | 0.2 | 845.57 | 0 | -76.50 | 243.10 | 6.00 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 4 | 165.60 | 41.40 | 100.0% | 14.1 | 1.2 | 141.20 | 0 | -103.50 | 41.85 | 4.00 |
| call_wall_acceptance_long | true | VALID_0DTE | VALID_0DTE | 1 | 91.00 | 91.00 | 100.0% | 12.0 | 0.2 | 455.00 | 0 | -11.70 | 131.30 | 28.66 |
| breakout_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 2 | 69.00 | 34.50 | 100.0% | 52.6 | 1.8 | 39.37 | 0 | -243.10 | 60.52 | 6.00 |
| breakout_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| wall_reclaim_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| wall_breakout_retest_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| late_day_pin_fade | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| negative_gamma_momentum_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| trend_day_pullback_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| breakout_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| pullback_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| squeeze_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |

## Strategy Entry Fingerprints

| Strategy | Enabled | Data State | Profile Set | Trades | Median Setup | Median ES-VWAP | Median RSI | Median ADX | Avg Hold Min | Slow >=12h |
| --- | --- | --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| pullback_long | true | VALID_0DTE | VALID_0DTE | 31 | 50.03 | 6.44 | 49.20 | 20.59 | 17.8 | 0 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 66.60 | 5.83 | 70.56 | 26.99 | 21.0 | 0 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 36 | 66.16 | 29.55 | 49.07 | 20.01 | 10.4 | 0 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 10 | 69.16 | 11.21 | 69.11 | 21.34 | 23.1 | 0 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 5 | 75.96 | 21.06 | 57.99 | 17.35 | 30.7 | 0 |
| breakout_long_no_0dte | true | EXPIRED_0DTE | EXPIRED_0DTE | 1 | 70.88 | 7.38 | 81.57 | 27.17 | 14.7 | 0 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 4 | 49.82 | 6.33 | 47.99 | 18.65 | 17.6 | 0 |
| call_wall_acceptance_long | true | VALID_0DTE | VALID_0DTE | 1 | 72.50 | 16.99 | 53.58 | 42.75 | 12.0 | 0 |
| breakout_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 2 | 78.32 | 11.24 | 80.45 | 28.97 | 52.6 | 0 |
| breakout_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| wall_reclaim_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| wall_breakout_retest_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| late_day_pin_fade | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| negative_gamma_momentum_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| trend_day_pullback_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| breakout_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 |  |  |  |  |  | 0 |
| pullback_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 |  |  |  |  |  | 0 |
| squeeze_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 |  |  |  |  |  | 0 |

## MAE And MFE
- MAE: average -95.98, median -70.97, worst -392.00
- MFE: average 82.87, median 60.38, best 441.00
- Average MFE / absolute MAE: 0.86

## Intratrade Path
- Trades with path stats: 110; with intratrade price samples: 110
- Went positive before max adverse: 52.7%
- MFE happened before MAE: 13.6%
- TP touched before MAE: 0.9%
- Median MFE available before MAE: 0.05 points
- Median first TP touch: 2.9 minutes
- Median first +1.5 points: 2.8 minutes
- First 15m MFE/MAE medians: 2.40 / -2.00 points

## Worst Tail Trade Autopsy
- Worst tail entry: `2026-07-06T19:48:01+00:00` -> `2026-07-06T22:00:56+00:00`.
- Strategy/profile: `pullback_long` / `pullback_long`. PnL -17.50, MAE -392.00, MFE , hold 132.9 minutes.
- Profile context: `pullback_long` produced 31 trades, PnL 2294.60, 0 slow >=12h trades, and 39.3% of total PnL.
- Entry state: setup=46.36, ES-VWAP=6.34, VWAP slope=0.0015, VWAP acceleration=0.0006, RSI=50.49, ADX=20.00, structure score=3.00, higher-low=-0.5000, higher-high=-4.00, pullback-from-high=1.25, rolling-high distance=8.25.
- Guard state: setup allowed=`True`, entry veto allowed=`True`, veto points=5.00, slow-risk points=0.00.
- Existing warning reason: setup quality 46.36 <= 50.00; ES structure score 3 <= 3; ES structure higher-low -0.50 < 0.25; ES structure higher-high -4.00 < 0.00; ADX slope -1.3066 <= -1.0000.
- Strategy selection reason: VALID_0DTE ordered router; ordered ES pullback: trendPrice=7586.75, ema=7586.99, distance=6.34, adx=20.00, rsi=50.49, structure=3.
- Intratrade path: path MFE 0.00, path MAE -11.20, MFE before MAE=`True`, TP reached=`False`.
- Surgical setup floor check: `setup_quality_score >= 46.4` would block this trade, keep 101 trades, retain 87.0% PnL, and leave worst MAE -379.80. It would block 9 trades total.
- No single candidate threshold in the report cleanly removes this tail; the closest visible guard is setup quality 46.36.

## Unscanned Feature Coverage
- Present trade columns: 144, scanned columns: 144, unscanned columns: 0
- No unscanned feature columns found. Good coverage for all present trade fields.

## Candidate Entry Quality Filters

| Scope | Condition | Kept | Blocked | Kept PnL | PnL Loss | Retained PnL | Slow Removed | Slow Left | Kept PnL/Exposure Hr | Kept Worst MAE | Score |
| --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| all | No useful single-threshold candidate found |  |  |  |  |  |  |  |  |  |  |

## Hidden MAE Signature Candidates

| Condition | Bad Trades | Bad Blocked | Good Blocked | Kept Trades | Kept PnL | PnL Loss | Retained PnL | Kept Worst MAE | Score |
| --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| `long_strategy != "breakout_long_1dte"` | 21 | 6 | 14 | 90 | 4827.60 | 1007.60 | 82.7% | -392.00 | 9529.7 |
| `strategy_profile != "breakout_long_1dte"` | 21 | 6 | 14 | 90 | 4827.60 | 1007.60 | 82.7% | -392.00 | 9529.7 |
| `es_structure_rising_vwap != "False"` | 21 | 7 | 13 | 90 | 4362.70 | 1472.50 | 74.8% | -392.00 | 9507.4 |
| `path_half_tp_touch_minutes >= 0.183333` | 21 | 15 | 23 | 72 | 4580.90 | 1254.30 | 78.5% | -379.80 | 739.7 |
| `es_structure_pullback_from_high <= 3.25` | 21 | 8 | 27 | 75 | 4437.30 | 1397.90 | 76.0% | -392.00 | 241.2 |
| `option_strike_map_target_1_strike >= 7475` | 21 | 6 | 10 | 94 | 4980.10 | 855.10 | 85.3% | -392.00 | 231.1 |
| `option_strike_map_atm_strike >= 7445` | 21 | 5 | 9 | 96 | 5126.30 | 708.90 | 87.9% | -392.00 | 192.2 |
| `option_strike_map_target_1_strike >= 7500` | 21 | 7 | 26 | 77 | 4363.00 | 1472.20 | 74.8% | -392.00 | 162.7 |
| `es_structure_pullback_from_high <= 3.75` | 21 | 7 | 24 | 79 | 4328.50 | 1506.70 | 74.2% | -392.00 | 159.5 |
| `es_structure_score <= 4` | 21 | 6 | 25 | 79 | 4516.60 | 1318.60 | 77.4% | -392.00 | 125.2 |
| `option_strike_map_atm_strike >= 7470` | 21 | 6 | 24 | 80 | 4454.80 | 1380.40 | 76.3% | -392.00 | 115.5 |
| `option_strike_map_atm_strike >= 7490` | 21 | 7 | 31 | 72 | 4128.40 | 1706.80 | 70.7% | -392.00 | 112.9 |

## Upside TP Extension Candidates
| all | No upside TP extension candidates found. |  |  |  |  |  |  |  |  |  |  |

## Event Counts
- blocked: 36851
- position_wait: 7428
- stale_es_vwap: 4867
- trade_risk_extend_signal: 1192
- trade_risk_tighten_signal: 1094
- order_event: 514
- waiting_spx_quote: 415
- entry_signal: 110
- trade_risk_exit_signal: 6

## Blocked Gate Counts
- setup_quality_allowed: 14989 (disabled=14989)
- above_vwap_confirmed: 9534 (disabled=9534)
- above_vwap: 8525 (disabled=8525)
- es_structure_allowed: 8281 (disabled=8281)
- pullback: 6751 (disabled=6751)
- momentum: 4456 (disabled=4456)
- es_vwap_max_distance_allowed: 3936 (disabled=3936)
- es_vwap_slope_allowed: 3710 (disabled=3710)
- trend_strength: 3587 (disabled=3587)
- es_vwap_acceleration_allowed: 1926 (disabled=1926)
- es_rolling_high_allowed: 529 (disabled=529)
- indicator_slope_allowed: 147 (disabled=147)

## By UTC Hour

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 13 | 12 | 728.40 | 60.70 | 100.0% | 0.4 |
| 8 | 11 | 784.90 | 71.35 | 81.8% | 16.6 |
| 12 | 10 | 130.80 | 13.08 | 90.0% | 12.4 |
| 14 | 10 | 851.90 | 85.19 | 100.0% | 2.1 |
| 1 | 6 | 509.10 | 84.85 | 100.0% | 3.0 |
| 15 | 6 | 368.10 | 61.35 | 100.0% | 9.2 |
| 18 | 6 | 336.60 | 56.10 | 100.0% | 10.4 |
| 9 | 6 | 323.80 | 53.97 | 100.0% | 14.0 |
| 11 | 5 | -75.10 | -15.02 | 80.0% | 12.0 |
| 19 | 5 | 197.80 | 39.56 | 80.0% | 17.0 |
| 5 | 5 | 241.00 | 48.20 | 100.0% | 20.6 |
| 6 | 5 | 243.10 | 48.62 | 100.0% | 16.4 |
| 2 | 4 | -77.60 | -19.40 | 75.0% | 48.6 |
| 22 | 4 | 392.90 | 98.23 | 100.0% | 14.9 |
| 7 | 4 | 240.70 | 60.17 | 100.0% | 12.0 |
| 0 | 3 | 174.40 | 58.13 | 100.0% | 12.1 |
| 10 | 2 | 55.40 | 27.70 | 100.0% | 18.4 |
| 23 | 2 | 70.00 | 35.00 | 100.0% | 29.5 |
| 3 | 2 | 146.20 | 73.10 | 100.0% | 15.9 |
| 17 | 1 | 119.00 | 119.00 | 100.0% | 7.3 |
| 4 | 1 | 73.80 | 73.80 | 100.0% | 4.2 |

## By RSI Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <55 | 59 | 3156.20 | 53.49 | 96.6% | 7.2 |
| 55-60 | 18 | 592.90 | 32.94 | 88.9% | 15.6 |
| >=75 | 11 | 1005.40 | 91.40 | 100.0% | 9.9 |
| 70-75 | 9 | 445.00 | 49.44 | 100.0% | 20.0 |
| 60-65 | 8 | 93.70 | 11.71 | 75.0% | 25.2 |
| 65-70 | 5 | 542.00 | 108.40 | 100.0% | 16.4 |

## By ADX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <20 | 45 | 2128.20 | 47.29 | 91.1% | 8.8 |
| 20-25 | 23 | 1400.80 | 60.90 | 95.7% | 12.7 |
| 25-30 | 18 | 1098.90 | 61.05 | 100.0% | 12.1 |
| 30-40 | 18 | 1120.30 | 62.24 | 100.0% | 12.0 |
| 40-50 | 5 | 48.50 | 9.70 | 80.0% | 12.0 |
| >=50 | 1 | 38.50 | 38.50 | 100.0% | 17.0 |

## By VIX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| missing | 110 | 5835.20 | 53.05 | 94.5% | 12.0 |

## By ES VWAP Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.25 | 106 | 5254.70 | 49.57 | 94.3% | 12.0 |
| 0.25-0.5 | 3 | 563.50 | 187.83 | 100.0% | 9.4 |
| 0.5-1 | 1 | 17.00 | 17.00 | 100.0% | 29.9 |

## By ES VWAP Acceleration Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.05 | 53 | 2515.30 | 47.46 | 94.3% | 12.1 |
| -0.05-0 | 38 | 1901.70 | 50.04 | 94.7% | 7.8 |
| 0.1-0.25 | 10 | 992.50 | 99.25 | 90.0% | 15.7 |
| 0.05-0.1 | 6 | 286.20 | 47.70 | 100.0% | 20.5 |
| >=0.25 | 2 | 52.00 | 26.00 | 100.0% | 55.9 |
| -0.25--0.1 | 1 | 87.50 | 87.50 | 100.0% | 6.7 |

## By ES Rolling High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-6 | 32 | 1547.50 | 48.36 | 100.0% | 7.8 |
| 2-4 | 24 | 1064.80 | 44.37 | 95.8% | 13.6 |
| 0-1 | 20 | 1339.80 | 66.99 | 95.0% | 13.9 |
| 6-8 | 14 | 919.90 | 65.71 | 85.7% | 10.8 |
| 8-12 | 8 | 342.00 | 42.75 | 87.5% | 13.0 |
| 1-2 | 6 | 399.20 | 66.53 | 100.0% | 18.6 |
| 12-20 | 5 | 187.00 | 37.40 | 80.0% | 6.6 |
| >=20 | 1 | 35.00 | 35.00 | 100.0% | 19.1 |

## By ES Rolling High Minutes Since

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 20-30 | 36 | 1716.70 | 47.69 | 91.7% | 9.2 |
| <1 | 24 | 1771.30 | 73.80 | 95.8% | 14.9 |
| 10-20 | 14 | 736.60 | 52.61 | 100.0% | 12.3 |
| 1-3 | 13 | 655.40 | 50.42 | 92.3% | 17.3 |
| 5-10 | 12 | 640.50 | 53.38 | 100.0% | 10.3 |
| 3-5 | 10 | 248.20 | 24.82 | 90.0% | 10.2 |
| 30-60 | 1 | 66.50 | 66.50 | 100.0% | 12.0 |

## By RSI Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| >=3 | 35 | 2521.50 | 72.04 | 97.1% | 12.7 |
| 0-1 | 21 | 1048.70 | 49.94 | 100.0% | 6.6 |
| -1-0 | 9 | 608.20 | 67.58 | 100.0% | 12.0 |
| <-3 | 9 | 163.70 | 18.19 | 88.9% | 6.7 |
| -2--1 | 8 | 236.40 | 29.55 | 87.5% | 16.6 |
| -3--2 | 8 | 69.50 | 8.69 | 87.5% | 6.8 |
| 1-2 | 8 | 558.50 | 69.81 | 100.0% | 13.5 |
| 2-3 | 6 | 187.30 | 31.22 | 66.7% | 17.8 |
| missing | 6 | 441.40 | 73.57 | 100.0% | 8.4 |

## By ADX Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-1 | 39 | 2531.50 | 64.91 | 97.4% | 12.0 |
| -1-0 | 35 | 1878.10 | 53.66 | 94.3% | 12.7 |
| 1-2 | 19 | 974.30 | 51.28 | 94.7% | 7.3 |
| -2--1 | 11 | 9.90 | 0.90 | 81.8% | 26.0 |
| missing | 6 | 441.40 | 73.57 | 100.0% | 8.4 |

## By ES Higher-Low Distance Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 2-4 | 34 | 1342.20 | 39.48 | 91.2% | 15.1 |
| 1-2 | 21 | 1145.90 | 54.57 | 100.0% | 8.4 |
| 4-8 | 21 | 1532.10 | 72.96 | 90.5% | 12.0 |
| >=8 | 16 | 1109.00 | 69.31 | 100.0% | 15.3 |
| 0-0.5 | 10 | 466.20 | 46.62 | 100.0% | 4.5 |
| 0.5-1 | 8 | 239.80 | 29.98 | 87.5% | 10.3 |

## By ES Structure Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4 | 41 | 2348.60 | 57.28 | 97.6% | 12.0 |
| 3 | 37 | 2134.00 | 57.68 | 91.9% | 12.0 |
| 5 | 31 | 1318.60 | 42.54 | 93.5% | 11.9 |
| 2 | 1 | 34.00 | 34.00 | 100.0% | 12.1 |

## By ES Structure Pullback From High

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-2 | 48 | 2926.10 | 60.96 | 93.8% | 12.6 |
| 2-4 | 31 | 1402.40 | 45.24 | 96.8% | 12.0 |
| 4-8 | 26 | 1538.20 | 59.16 | 96.2% | 8.5 |
| 8-12 | 5 | -31.50 | -6.30 | 80.0% | 17.3 |

## By ES Structure Higher-Low Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 42 | 2266.40 | 53.96 | 92.9% | 13.3 |
| 2-4 | 17 | 93.00 | 5.47 | 88.2% | 20.0 |
| 0.5-1 | 11 | 956.10 | 86.92 | 100.0% | 3.8 |
| 1-2 | 11 | 851.60 | 77.42 | 100.0% | 12.0 |
| 4-8 | 11 | 561.00 | 51.00 | 100.0% | 9.9 |
| 0-0.5 | 9 | 390.60 | 43.40 | 88.9% | 9.7 |
| >=8 | 9 | 716.50 | 79.61 | 100.0% | 12.0 |

## By ES Structure Higher-High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 41 | 2267.00 | 55.29 | 95.1% | 8.7 |
| 2-4 | 19 | 824.90 | 43.42 | 89.5% | 9.4 |
| 4-8 | 16 | 1087.00 | 67.94 | 93.8% | 12.1 |
| 1-2 | 15 | 890.30 | 59.35 | 100.0% | 20.0 |
| >=8 | 9 | 557.00 | 61.89 | 100.0% | 14.7 |
| 0-0.5 | 6 | -42.90 | -7.15 | 83.3% | 19.0 |
| 0.5-1 | 4 | 251.90 | 62.98 | 100.0% | 10.4 |

## By ES Structure VWAP Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 38 | 2594.80 | 68.28 | 97.4% | 13.9 |
| >=24 | 32 | 574.60 | 17.96 | 93.8% | 5.0 |
| 8-12 | 15 | 809.00 | 53.93 | 86.7% | 23.3 |
| 2-4 | 8 | 544.50 | 68.06 | 87.5% | 9.3 |
| 12-16 | 7 | 425.10 | 60.73 | 100.0% | 12.0 |
| 16-24 | 6 | 662.30 | 110.38 | 100.0% | 10.7 |
| 0-2 | 4 | 224.90 | 56.22 | 100.0% | 11.9 |

## By Setup Quality Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 50-60 | 34 | 1870.60 | 55.02 | 94.1% | 7.5 |
| 60-70 | 27 | 860.30 | 31.86 | 92.6% | 12.1 |
| 70-80 | 20 | 1548.50 | 77.43 | 100.0% | 12.0 |
| 40-50 | 18 | 1261.20 | 70.07 | 94.4% | 12.3 |
| 80-90 | 11 | 294.60 | 26.78 | 90.9% | 16.6 |

## By Entry-Veto Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 3-4 | 24 | 1457.70 | 60.74 | 100.0% | 11.9 |
| 1-2 | 23 | 1103.20 | 47.97 | 91.3% | 12.1 |
| 2-3 | 22 | 952.30 | 43.29 | 100.0% | 15.8 |
| 4-5 | 18 | 889.80 | 49.43 | 88.9% | 10.7 |
| 5-6 | 14 | 694.30 | 49.59 | 85.7% | 7.2 |
| <1 | 9 | 737.90 | 81.99 | 100.0% | 12.0 |

## By Slow-Risk Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <1 | 110 | 5835.20 | 53.05 | 94.5% | 12.0 |

## By Entry Risk Tier

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| standard | 110 | 5835.20 | 53.05 | 94.5% | 12.0 |

## By ES Reclaim Current Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 38 | 2594.80 | 68.28 | 97.4% | 13.9 |
| >=24 | 32 | 574.60 | 17.96 | 93.8% | 5.0 |
| 8-12 | 15 | 809.00 | 53.93 | 86.7% | 23.3 |
| 2-4 | 8 | 544.50 | 68.06 | 87.5% | 9.3 |
| 12-16 | 7 | 425.10 | 60.73 | 100.0% | 12.0 |
| 16-24 | 6 | 662.30 | 110.38 | 100.0% | 10.7 |
| 0-2 | 4 | 224.90 | 56.22 | 100.0% | 11.9 |

## By SPX EMA20 Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 72 | 3642.60 | 50.59 | 94.4% | 8.8 |
| 2-4 | 13 | 716.20 | 55.09 | 92.3% | 24.9 |
| 4-6 | 8 | 582.50 | 72.81 | 100.0% | 10.9 |
| 8-12 | 5 | 650.10 | 130.02 | 100.0% | 12.1 |
| >=12 | 5 | 228.80 | 45.76 | 100.0% | 16.6 |
| 1-2 | 4 | -146.00 | -36.50 | 75.0% | 54.7 |
| 6-8 | 2 | 70.00 | 35.00 | 100.0% | 40.7 |
| 0-1 | 1 | 91.00 | 91.00 | 100.0% | 12.0 |

## By Hold-Time Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 5-15 | 38 | 3433.30 | 90.35 | 100.0% | 10.9 |
| 15-30 | 31 | 475.90 | 15.35 | 93.5% | 20.0 |
| <5 | 28 | 1948.20 | 69.58 | 100.0% | 1.4 |
| 30-60 | 7 | 202.50 | 28.93 | 100.0% | 38.0 |
| 60-180 | 6 | -224.70 | -37.45 | 33.3% | 90.0 |

## By VIX Regime

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| disabled | 110 | 5835.20 | 53.05 | 94.5% | 12.0 |

## By Option Data State

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 83 | 4385.60 | 52.84 | 94.0% | 12.0 |
| VALID_1DTE_ONLY | 20 | 1007.60 | 50.38 | 95.0% | 14.1 |
| STALE_0DTE | 6 | 234.60 | 39.10 | 100.0% | 19.8 |
| EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 |

## By Active Profile Set

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 83 | 4385.60 | 52.84 | 94.0% | 12.0 |
| VALID_1DTE_ONLY | 20 | 1007.60 | 50.38 | 95.0% | 14.1 |
| STALE_0DTE | 6 | 234.60 | 39.10 | 100.0% | 19.8 |
| EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 |

## Monthly Summary

| Month | Trades | PnL | Avg PnL | Median Hold Min | Exposure Hours | PnL/Exposure Hour | Slow >=12h |
| --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| 2026-06 | 71 | 3857.40 | 54.33 | 12.0 | 15.5 | 249.13 | 0 |
| 2026-07 | 39 | 1977.80 | 50.71 | 13.2 | 16.7 | 118.38 | 0 |

## TP Target Distribution

| Target | Trades | PnL | Avg PnL | Median Hold Min |
| --- | ---: | ---: | ---: | ---: |
| 2.34 | 1 | 84.00 | 84.00 | 3.0 |
| 2.40 | 36 | 762.40 | 21.18 | 6.1 |
| 2.49 | 1 | 45.50 | 45.50 | 20.6 |
| 2.57 | 1 | 93.60 | 93.60 | 5.3 |
| 2.63 | 1 | 39.60 | 39.60 | 12.0 |
| 2.99 | 1 | 105.00 | 105.00 | 8.5 |
| 3.00 | 20 | 1007.60 | 50.38 | 14.1 |
| 3.02 | 2 | 101.30 | 50.65 | 49.8 |
| 3.09 | 1 | 55.80 | 55.80 | 11.9 |
| 3.13 | 1 | 59.50 | 59.50 | 12.0 |
| 3.14 | 1 | 108.50 | 108.50 | 6.5 |
| 3.19 | 1 | 35.00 | 35.00 | 26.0 |
| 3.22 | 1 | 115.50 | 115.50 | 6.6 |
| 3.26 | 1 | 115.50 | 115.50 | 3.8 |
| 3.30 | 1 | 118.80 | 118.80 | 0.1 |
| 3.31 | 2 | 69.00 | 34.50 | 17.2 |
| 3.33 | 1 | 36.00 | 36.00 | 29.9 |
| 3.34 | 1 | -17.50 | -17.50 | 132.9 |
| 3.35 | 1 | 119.00 | 119.00 | 8.4 |
| 3.43 | 1 | 46.80 | 46.80 | 12.7 |
| 3.44 | 1 | 119.00 | 119.00 | 7.3 |
| 3.46 | 1 | 136.50 | 136.50 | 8.8 |
| 3.48 | 1 | 122.50 | 122.50 | 5.8 |
| 3.51 | 1 | 35.00 | 35.00 | 17.4 |
| 3.56 | 1 | 36.00 | 36.00 | 15.6 |
| 3.58 | 1 | 35.00 | 35.00 | 23.6 |
| 3.60 | 6 | 535.50 | 89.25 | 9.5 |
| 4.00 | 3 | 109.80 | 36.60 | 16.4 |
| 6.00 | 3 | 276.40 | 92.13 | 23.3 |
| 12.00 | 5 | 517.60 | 103.52 | 16.0 |
| 14.06 | 1 | 34.00 | 34.00 | 12.1 |
| 15.00 | 1 | 45.50 | 45.50 | 44.6 |
| 16.25 | 1 | 35.00 | 35.00 | 23.6 |
| 23.75 | 1 | 35.00 | 35.00 | 57.7 |
| 28.44 | 1 | 112.20 | 112.20 | 12.0 |
| 28.66 | 1 | 91.00 | 91.00 | 12.0 |
| 38.75 | 2 | 125.80 | 62.90 | 14.7 |
| 48.62 | 2 | 70.00 | 35.00 | 19.9 |
| 55.78 | 1 | 262.50 | 262.50 | 12.0 |

## Slow Trade Fingerprint
- Trades held >= 12 hours: 0 (0.0%)

## Interpretation Notes
- This strategy exits with take-profit orders only, so a high win rate can hide capital being tied up for a long time.
- The best setting candidates are usually found by reducing slow-to-profit entries, not simply maximizing raw entry count.
- Focus first on buckets with low average PnL or long median hold time, then test stricter RSI/ADX/VWAP/VIX filters against those buckets.
