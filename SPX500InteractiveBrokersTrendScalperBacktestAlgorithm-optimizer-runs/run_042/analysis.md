# SPX500 IB Trend Scalper Analysis

- Metrics file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_042/execution-metrics.csv`
- Backtest file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_042/launcher/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm.json`
- Completed paired trades: 72
- Entry signals: 72
- Approx open/unpaired entry signals: 0
- Position/order maintenance waits: 18760
- Total paired trade PnL: 4273.40
- Win rate: 100.0%
- Realized loss trades: 0
- Median hold: 12.9 minutes
- Average hold: 112.0 minutes

## Lean Runtime Statistics
- Equity: $104,273.40
- Net Profit: $4,273.40
- Return: 4.27 %
- Probabilistic Sharpe Ratio: 100%
- Volume: $30,351,099.00

## Risk And Efficiency
- Exposure hours: 134.3
- PnL per exposure hour: 31.81
- Calendar span days: 12.3
- PnL per calendar day: 346.94
- Trades per calendar day: 5.85
- Exposure share of calendar time: 45.4%
- Growth quality score: 5753.8
- VIX stale at entry: 0.0%
- ES stale rows: 9.4%
- Waiting ES VWAP rows: 0.0%
- Trade-health exit signals: 0
- Trade-health tighten signals: 0
- Slow trades held >= 12 hours: 1 (1.4%)
- Slow exposure hours: 96.2
- Slow PnL per exposure hour: 0.35
- Fast <15m trades: 38
- Fast PnL per exposure hour: 849.83

## Pullback Broken Structure Veto
- Blocked signal rows: 550
- Blocked by profile: `{"charm_pin_pullback_long": 528, "pullback_long": 22}`
- Blocked net profit / worst MAE: not available for hard-blocked signals because they do not become completed trades.
- Remaining trades by profile: `{"breakout_long_1dte": 13, "breakout_long_no_0dte": 1, "charm_pin_pullback_long": 23, "charm_wall_breakaway_long": 1, "pullback_long": 25, "pullback_long_no_0dte": 4, "squeeze_long": 5}`
- Remaining PnL by profile: `{"breakout_long_1dte": 746.6999999999489, "breakout_long_no_0dte": 35.0, "charm_pin_pullback_long": 850.0000000001546, "charm_wall_breakaway_long": 437.5, "pullback_long": 1866.6000000001068, "pullback_long_no_0dte": 156.3999999999969, "squeeze_long": 181.20000000000618}`

## Lean Portfolio And Trade Statistics
- Portfolio: sharpeRatio=35.4278, sortinoRatio=0, alpha=0, beta=0, informationRatio=35.9204, drawdown=0.042
- Trades: sharpeRatio=1.0446, averageMAE=-162.6736, averageMFE=76.0660, largestMAE=-4394.50, largestMFE=449.75, maximumIntraTradeDrawdown=-4452.30

## Strategy Profile Performance

| Strategy | Enabled | Data State | Profile Set | Trades | PnL | Avg PnL | Win Rate | Median Hold Min | Exposure Hrs | PnL/Exposure Hr | Slow >=12h | Worst MAE | Median MFE | Median TP |
| --- | --- | --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| pullback_long | true | VALID_0DTE | VALID_0DTE | 25 | 1866.60 | 74.66 | 100.0% | 12.0 | 111.7 | 16.72 | 1 | -4394.50 | 93.50 | 3.44 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 23 | 850.00 | 36.96 | 100.0% | 3.0 | 6.5 | 130.48 | 0 | -352.75 | 47.60 | 2.40 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 13 | 746.70 | 57.44 | 100.0% | 16.5 | 6.4 | 116.89 | 0 | -355.25 | 76.50 | 3.00 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 1 | 437.50 | 437.50 | 100.0% | 198.3 | 3.3 | 132.35 | 0 | -89.25 | 449.75 | 12.00 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 5 | 181.20 | 36.24 | 100.0% | 25.7 | 2.7 | 66.39 | 0 | -202.30 | 66.30 | 16.25 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 4 | 156.40 | 39.10 | 100.0% | 21.2 | 2.4 | 65.51 | 0 | -131.75 | 39.53 | 4.00 |
| breakout_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 1 | 35.00 | 35.00 | 100.0% | 81.9 | 1.4 | 25.65 | 0 | -166.25 | 71.75 | 6.00 |
| breakout_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| wall_reclaim_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| wall_breakout_retest_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| late_day_pin_fade | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| negative_gamma_momentum_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| trend_day_pullback_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| call_wall_acceptance_long | true | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| breakout_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| pullback_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| squeeze_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |

## Strategy Entry Fingerprints

| Strategy | Enabled | Data State | Profile Set | Trades | Median Setup | Median ES-VWAP | Median RSI | Median ADX | Avg Hold Min | Slow >=12h |
| --- | --- | --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| pullback_long | true | VALID_0DTE | VALID_0DTE | 25 | 50.91 | 6.71 | 50.50 | 21.81 | 268.0 | 1 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 23 | 66.87 | 30.16 | 51.32 | 20.09 | 17.0 | 0 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 13 | 68.27 | 5.38 | 70.87 | 26.13 | 29.5 | 0 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 1 | 58.34 | 10.69 | 55.57 | 17.35 | 198.3 | 0 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 5 | 63.01 | 9.93 | 67.57 | 21.23 | 32.8 | 0 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 4 | 51.73 | 6.62 | 51.78 | 17.87 | 35.8 | 0 |
| breakout_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 1 | 75.91 | 11.91 | 87.85 | 27.99 | 81.9 | 0 |
| breakout_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| wall_reclaim_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| wall_breakout_retest_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| late_day_pin_fade | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| negative_gamma_momentum_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| trend_day_pullback_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| call_wall_acceptance_long | true | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| breakout_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 |  |  |  |  |  | 0 |
| pullback_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 |  |  |  |  |  | 0 |
| squeeze_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 |  |  |  |  |  | 0 |

## MAE And MFE
- MAE: average -162.67, median -71.75, worst -4394.50
- MFE: average 76.07, median 59.50, best 449.75
- Average MFE / absolute MAE: 0.47

## Intratrade Path
- Trades with path stats: 72; with intratrade price samples: 72
- Went positive before max adverse: 51.4%
- MFE happened before MAE: 12.5%
- TP touched before MAE: 0.0%
- Median MFE available before MAE: 0.05 points
- Median first TP touch: 2.9 minutes
- Median first +1.5 points: 2.8 minutes
- First 15m MFE/MAE medians: 2.40 / -2.00 points

## Worst Tail Trade Autopsy
- Worst tail entry: `2026-06-25T13:30:53+00:00` -> `2026-06-29T13:45:51+00:00`.
- Strategy/profile: `pullback_long` / `pullback_long`. PnL 34.00, MAE -4394.50, MFE 57.80, hold 5775.0 minutes.
- Profile context: `pullback_long` produced 25 trades, PnL 1866.60, 1 slow >=12h trades, and 43.7% of total PnL.
- Entry state: setup=63.31, ES-VWAP=4.54, VWAP slope=0.0184, VWAP acceleration=0.0135, RSI=80.41, ADX=31.17, structure score=3.00, higher-low=13.25, higher-high=8.25, pullback-from-high=10.00, rolling-high distance=10.00.
- Guard state: setup allowed=`True`, entry veto allowed=`True`, veto points=4.00, slow-risk points=0.00.
- Existing warning reason: ES structure score 3 <= 3; ES pullback from high 10.00 >= 5.00; ES recent high rejection distance 10.00 >= 5.00, minutes 2.55 <= 15.00; RSI 80.41 >= 70.00.
- Strategy selection reason: VALID_0DTE ordered router; ordered ES pullback: trendPrice=7446.50, ema=7446.51, distance=4.54, adx=31.17, rsi=80.41, structure=3.
- Intratrade path: path MFE 1.70, path MAE -128.95, MFE before MAE=`False`, TP reached=`False`.
- Surgical setup floor check: `setup_quality_score >= 63.4` would block this trade, keep 25 trades, retain 23.7% PnL, and leave worst MAE -355.25. It would block 47 trades total.
- Candidate guards that would have blocked this tail:
  - `es_rolling_high_minutes_since >= 3`: kept 49 trades, retained 74.6% PnL, kept worst MAE -586.50.
  - `es_rolling_high_minutes_since >= 5`: kept 42 trades, retained 67.2% PnL, kept worst MAE -586.50.

## Unscanned Feature Coverage
- Present trade columns: 144, scanned columns: 144, unscanned columns: 0
- No unscanned feature columns found. Good coverage for all present trade fields.

## Candidate Entry Quality Filters

| Scope | Condition | Kept | Blocked | Kept PnL | PnL Loss | Retained PnL | Slow Removed | Slow Left | Kept PnL/Exposure Hr | Kept Worst MAE | Score |
| --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| all_trades | `es_rolling_high_minutes_since >= 3` | 49 | 23 | 3188.10 | 1085.30 | 74.6% | 1 | 0 | 163.26 | -586.50 | 149.7 |
| all_trades | `es_rolling_high_minutes_since >= 5` | 42 | 30 | 2870.80 | 1402.60 | 67.2% | 1 | 0 | 171.19 | -586.50 | 91.5 |

## Hidden MAE Signature Candidates

| Condition | Bad Trades | Bad Blocked | Good Blocked | Kept Trades | Kept PnL | PnL Loss | Retained PnL | Kept Worst MAE | Score |
| --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| `long_strategy != "breakout_long_1dte"` | 14 | 4 | 9 | 59 | 3526.70 | 746.70 | 82.5% | -4394.50 | 105644.8 |
| `strategy_profile != "breakout_long_1dte"` | 14 | 4 | 9 | 59 | 3526.70 | 746.70 | 82.5% | -4394.50 | 105644.8 |
| `long_strategy != "charm_pin_pullback_long"` | 14 | 3 | 20 | 49 | 3423.40 | 850.00 | 80.1% | -4394.50 | 105439.8 |
| `strategy_profile != "charm_pin_pullback_long"` | 14 | 3 | 20 | 49 | 3423.40 | 850.00 | 80.1% | -4394.50 | 105439.8 |
| `es_structure_rising_vwap != "False"` | 14 | 5 | 6 | 61 | 3739.20 | 534.20 | 87.5% | -620.50 | 60521.6 |
| `es_structure_shallow_pullback != "False"` | 14 | 3 | 5 | 64 | 3901.90 | 371.50 | 91.3% | -620.50 | 60363.9 |
| `path_half_tp_touch_minutes >= 0.166667` | 14 | 6 | 14 | 52 | 3541.90 | 731.50 | 82.9% | -4394.50 | 447.3 |
| `path_first_observed_points >= -0.25` | 14 | 5 | 17 | 50 | 3105.40 | 1168.00 | 72.7% | -586.50 | 264.3 |
| `path_first_nonzero_move_points >= -0.25` | 14 | 5 | 17 | 50 | 3105.40 | 1168.00 | 72.7% | -586.50 | 264.3 |
| `long_strategy_max_take_profit_distance >= 5` | 14 | 5 | 28 | 39 | 3050.80 | 1222.60 | 71.4% | -4394.50 | 237.9 |
| `path_first_observed_points >= -0.35` | 14 | 4 | 16 | 52 | 3253.30 | 1020.10 | 76.1% | -586.50 | 192.4 |
| `path_first_nonzero_move_points >= -0.35` | 14 | 4 | 16 | 52 | 3253.30 | 1020.10 | 76.1% | -586.50 | 192.4 |

## Upside TP Extension Candidates
| all | No upside TP extension candidates found. |  |  |  |  |  |  |  |  |  |  |

## Event Counts
- blocked: 25519
- position_wait: 18760
- stale_es_vwap: 4867
- trade_risk_extend_signal: 1192
- trade_risk_tighten_signal: 490
- waiting_spx_quote: 415
- order_event: 325
- entry_signal: 72

## Blocked Gate Counts
- setup_quality_allowed: 10335 (disabled=10335)
- above_vwap_confirmed: 5744 (disabled=5744)
- above_vwap: 5183 (disabled=5183)
- es_structure_allowed: 4803 (disabled=4803)
- pullback: 4284 (disabled=4284)
- es_vwap_slope_allowed: 3122 (disabled=3122)
- momentum: 2654 (disabled=2654)
- es_vwap_max_distance_allowed: 2388 (disabled=2388)
- trend_strength: 2100 (disabled=2100)
- es_vwap_acceleration_allowed: 1129 (disabled=1129)
- es_rolling_high_allowed: 109 (disabled=109)
- indicator_slope_allowed: 99 (disabled=99)

## By UTC Hour

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 14 | 9 | 343.40 | 38.16 | 100.0% | 0.8 |
| 8 | 9 | 922.10 | 102.46 | 100.0% | 57.7 |
| 13 | 7 | 518.10 | 74.01 | 100.0% | 2.3 |
| 15 | 7 | 452.20 | 64.60 | 100.0% | 7.5 |
| 1 | 5 | 395.50 | 79.10 | 100.0% | 1.6 |
| 18 | 5 | 251.60 | 50.32 | 100.0% | 9.7 |
| 11 | 4 | 134.30 | 33.57 | 100.0% | 68.6 |
| 5 | 4 | 123.40 | 30.85 | 100.0% | 56.3 |
| 19 | 3 | 198.20 | 66.07 | 100.0% | 8.4 |
| 22 | 3 | 180.20 | 60.07 | 100.0% | 15.0 |
| 6 | 3 | 99.70 | 33.23 | 100.0% | 16.4 |
| 7 | 3 | 103.00 | 34.33 | 100.0% | 16.9 |
| 12 | 2 | 175.00 | 87.50 | 100.0% | 12.0 |
| 2 | 2 | 69.00 | 34.50 | 100.0% | 105.4 |
| 23 | 2 | 68.00 | 34.00 | 100.0% | 29.5 |
| 0 | 1 | 34.00 | 34.00 | 100.0% | 35.4 |
| 10 | 1 | 20.40 | 20.40 | 100.0% | 22.9 |
| 17 | 1 | 115.60 | 115.60 | 100.0% | 7.3 |
| 4 | 1 | 69.70 | 69.70 | 100.0% | 26.0 |

## By RSI Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <55 | 39 | 2445.90 | 62.72 | 100.0% | 7.5 |
| 55-60 | 10 | 707.50 | 70.75 | 100.0% | 53.6 |
| >=75 | 8 | 575.70 | 71.96 | 100.0% | 9.5 |
| 60-65 | 6 | 238.30 | 39.72 | 100.0% | 35.2 |
| 65-70 | 6 | 204.00 | 34.00 | 100.0% | 14.2 |
| 70-75 | 3 | 102.00 | 34.00 | 100.0% | 32.1 |

## By ADX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <20 | 31 | 1991.20 | 64.23 | 100.0% | 11.9 |
| 20-25 | 14 | 738.50 | 52.75 | 100.0% | 14.6 |
| 25-30 | 12 | 620.30 | 51.69 | 100.0% | 11.9 |
| 30-40 | 11 | 803.40 | 73.04 | 100.0% | 13.2 |
| 40-50 | 3 | 85.00 | 28.33 | 100.0% | 24.0 |
| >=50 | 1 | 35.00 | 35.00 | 100.0% | 16.4 |

## By VIX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| missing | 72 | 4273.40 | 59.35 | 100.0% | 12.9 |

## By ES VWAP Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.25 | 68 | 4075.20 | 59.93 | 100.0% | 12.9 |
| 0.25-0.5 | 3 | 181.20 | 60.40 | 100.0% | 5.8 |
| 0.5-1 | 1 | 17.00 | 17.00 | 100.0% | 29.9 |

## By ES VWAP Acceleration Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.05 | 31 | 1939.50 | 62.56 | 100.0% | 16.4 |
| -0.05-0 | 29 | 1814.10 | 62.56 | 100.0% | 6.2 |
| 0.1-0.25 | 6 | 283.20 | 47.20 | 100.0% | 18.5 |
| 0.05-0.1 | 3 | 103.00 | 34.33 | 100.0% | 23.6 |
| >=0.25 | 2 | 52.00 | 26.00 | 100.0% | 55.9 |
| <-0.25 | 1 | 81.60 | 81.60 | 100.0% | 2.4 |

## By ES Rolling High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 2-4 | 22 | 1008.70 | 45.85 | 100.0% | 15.2 |
| 4-6 | 13 | 691.90 | 53.22 | 100.0% | 2.3 |
| 0-1 | 12 | 722.90 | 60.24 | 100.0% | 19.9 |
| 6-8 | 10 | 833.90 | 83.39 | 100.0% | 14.2 |
| 1-2 | 6 | 332.50 | 55.42 | 100.0% | 17.2 |
| 12-20 | 4 | 435.00 | 108.75 | 100.0% | 3.1 |
| 8-12 | 4 | 214.50 | 53.62 | 100.0% | 23.4 |
| >=20 | 1 | 34.00 | 34.00 | 100.0% | 19.1 |

## By ES Rolling High Minutes Since

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 20-30 | 17 | 1474.20 | 86.72 | 100.0% | 16.4 |
| <1 | 15 | 790.90 | 52.73 | 100.0% | 23.6 |
| 10-20 | 12 | 650.40 | 54.20 | 100.0% | 9.9 |
| 5-10 | 12 | 712.20 | 59.35 | 100.0% | 5.4 |
| 1-3 | 8 | 294.40 | 36.80 | 100.0% | 61.0 |
| 3-5 | 7 | 317.30 | 45.33 | 100.0% | 11.9 |
| 30-60 | 1 | 34.00 | 34.00 | 100.0% | 269.6 |

## By RSI Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| >=3 | 24 | 1424.90 | 59.37 | 100.0% | 12.4 |
| 0-1 | 11 | 523.50 | 47.59 | 100.0% | 19.1 |
| -2--1 | 7 | 463.80 | 66.26 | 100.0% | 24.0 |
| -3--2 | 7 | 279.20 | 39.89 | 100.0% | 4.5 |
| 1-2 | 6 | 381.70 | 63.62 | 100.0% | 15.8 |
| -1-0 | 5 | 273.00 | 54.60 | 100.0% | 9.7 |
| <-3 | 5 | 195.50 | 39.10 | 100.0% | 2.3 |
| missing | 4 | 224.30 | 56.08 | 100.0% | 14.4 |
| 2-3 | 3 | 507.50 | 169.17 | 100.0% | 90.2 |

## By ADX Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-1 | 28 | 1337.70 | 47.78 | 100.0% | 11.9 |
| -1-0 | 26 | 1857.60 | 71.45 | 100.0% | 15.2 |
| 1-2 | 10 | 709.00 | 70.90 | 100.0% | 9.7 |
| -2--1 | 4 | 144.80 | 36.20 | 100.0% | 26.0 |
| missing | 4 | 224.30 | 56.08 | 100.0% | 14.4 |

## By ES Higher-Low Distance Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 2-4 | 27 | 1329.40 | 49.24 | 100.0% | 16.5 |
| 1-2 | 17 | 1044.90 | 61.46 | 100.0% | 8.4 |
| 4-8 | 11 | 1175.70 | 106.88 | 100.0% | 11.4 |
| 0-0.5 | 8 | 400.80 | 50.10 | 100.0% | 4.5 |
| >=8 | 6 | 206.00 | 34.33 | 100.0% | 41.7 |
| 0.5-1 | 3 | 116.60 | 38.87 | 100.0% | 11.9 |

## By ES Structure Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 5 | 25 | 1348.40 | 53.94 | 100.0% | 9.7 |
| 3 | 24 | 1789.60 | 74.57 | 100.0% | 15.7 |
| 4 | 22 | 1101.40 | 50.06 | 100.0% | 20.3 |
| 2 | 1 | 34.00 | 34.00 | 100.0% | 12.1 |

## By ES Structure Pullback From High

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-2 | 29 | 1959.60 | 67.57 | 100.0% | 16.5 |
| 2-4 | 22 | 1326.90 | 60.31 | 100.0% | 11.9 |
| 4-8 | 18 | 854.30 | 47.46 | 100.0% | 2.6 |
| 8-12 | 2 | 51.00 | 25.50 | 100.0% | 2902.4 |
| 12-16 | 1 | 81.60 | 81.60 | 100.0% | 2.4 |

## By ES Structure Higher-Low Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 29 | 1879.10 | 64.80 | 100.0% | 16.4 |
| 2-4 | 12 | 439.60 | 36.63 | 100.0% | 26.4 |
| 1-2 | 10 | 582.40 | 58.24 | 100.0% | 14.4 |
| 0.5-1 | 7 | 645.50 | 92.21 | 100.0% | 2.3 |
| 4-8 | 6 | 225.50 | 37.58 | 100.0% | 8.3 |
| 0-0.5 | 5 | 399.30 | 79.86 | 100.0% | 6.6 |
| >=8 | 3 | 102.00 | 34.00 | 100.0% | 57.7 |

## By ES Structure Higher-High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 25 | 1997.80 | 79.91 | 100.0% | 11.4 |
| 1-2 | 13 | 780.90 | 60.07 | 100.0% | 23.6 |
| 2-4 | 12 | 603.20 | 50.27 | 100.0% | 1.7 |
| 4-8 | 8 | 397.80 | 49.72 | 100.0% | 23.2 |
| 0-0.5 | 5 | 184.60 | 36.92 | 100.0% | 17.8 |
| 0.5-1 | 5 | 172.10 | 34.42 | 100.0% | 25.7 |
| >=8 | 4 | 137.00 | 34.25 | 100.0% | 69.8 |

## By ES Structure VWAP Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 27 | 1644.80 | 60.92 | 100.0% | 15.6 |
| >=24 | 20 | 710.60 | 35.53 | 100.0% | 2.7 |
| 8-12 | 12 | 1132.80 | 94.40 | 100.0% | 24.7 |
| 2-4 | 6 | 435.60 | 72.60 | 100.0% | 15.5 |
| 0-2 | 4 | 210.20 | 52.55 | 100.0% | 11.9 |
| 12-16 | 2 | 98.60 | 49.30 | 100.0% | 9.9 |
| 16-24 | 1 | 40.80 | 40.80 | 100.0% | 7.5 |

## By Setup Quality Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 50-60 | 25 | 1921.50 | 76.86 | 100.0% | 12.0 |
| 60-70 | 17 | 695.30 | 40.90 | 100.0% | 12.1 |
| 40-50 | 13 | 937.50 | 72.12 | 100.0% | 12.6 |
| 70-80 | 12 | 538.90 | 44.91 | 100.0% | 9.5 |
| 80-90 | 3 | 115.60 | 38.53 | 100.0% | 15.0 |
| >=90 | 2 | 64.60 | 32.30 | 100.0% | 68.6 |

## By Entry-Veto Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 1-2 | 18 | 1080.60 | 60.03 | 100.0% | 11.4 |
| 3-4 | 15 | 958.40 | 63.89 | 100.0% | 7.5 |
| 2-3 | 14 | 474.30 | 33.88 | 100.0% | 24.3 |
| 4-5 | 11 | 945.80 | 85.98 | 100.0% | 14.9 |
| 5-6 | 9 | 629.00 | 69.89 | 100.0% | 7.3 |
| <1 | 5 | 185.30 | 37.06 | 100.0% | 24.0 |

## By Slow-Risk Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <1 | 72 | 4273.40 | 59.35 | 100.0% | 12.9 |

## By Entry Risk Tier

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| standard | 72 | 4273.40 | 59.35 | 100.0% | 12.9 |

## By ES Reclaim Current Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 27 | 1644.80 | 60.92 | 100.0% | 15.6 |
| >=24 | 20 | 710.60 | 35.53 | 100.0% | 2.7 |
| 8-12 | 12 | 1132.80 | 94.40 | 100.0% | 24.7 |
| 2-4 | 6 | 435.60 | 72.60 | 100.0% | 15.5 |
| 0-2 | 4 | 210.20 | 52.55 | 100.0% | 11.9 |
| 12-16 | 2 | 98.60 | 49.30 | 100.0% | 9.9 |
| 16-24 | 1 | 40.80 | 40.80 | 100.0% | 7.5 |

## By SPX EMA20 Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 52 | 2873.00 | 55.25 | 100.0% | 10.5 |
| 2-4 | 9 | 941.80 | 104.64 | 100.0% | 15.0 |
| 1-2 | 5 | 182.20 | 36.44 | 100.0% | 44.6 |
| 4-6 | 2 | 139.40 | 69.70 | 100.0% | 31.8 |
| 8-12 | 2 | 69.00 | 34.50 | 100.0% | 47.0 |
| 0-1 | 1 | 34.00 | 34.00 | 100.0% | 32.1 |
| 6-8 | 1 | 34.00 | 34.00 | 100.0% | 23.6 |

## By Hold-Time Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <5 | 22 | 1501.90 | 68.27 | 100.0% | 1.4 |
| 15-30 | 19 | 600.00 | 31.58 | 100.0% | 19.1 |
| 5-15 | 16 | 1266.90 | 79.18 | 100.0% | 10.5 |
| 60-180 | 7 | 215.50 | 30.79 | 100.0% | 90.2 |
| 30-60 | 4 | 146.20 | 36.55 | 100.0% | 40.0 |
| 180-720 | 3 | 508.90 | 169.63 | 100.0% | 269.6 |
| >=720 | 1 | 34.00 | 34.00 | 100.0% | 5775.0 |

## By VIX Regime

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| disabled | 72 | 4273.40 | 59.35 | 100.0% | 12.9 |

## By Option Data State

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 54 | 3335.30 | 61.76 | 100.0% | 11.6 |
| VALID_1DTE_ONLY | 13 | 746.70 | 57.44 | 100.0% | 16.5 |
| STALE_0DTE | 5 | 191.40 | 38.28 | 100.0% | 26.0 |

## By Active Profile Set

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 54 | 3335.30 | 61.76 | 100.0% | 11.6 |
| VALID_1DTE_ONLY | 13 | 746.70 | 57.44 | 100.0% | 16.5 |
| STALE_0DTE | 5 | 191.40 | 38.28 | 100.0% | 26.0 |

## Monthly Summary

| Month | Trades | PnL | Avg PnL | Median Hold Min | Exposure Hours | PnL/Exposure Hour | Slow >=12h |
| --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| 2026-06 | 39 | 1944.80 | 49.87 | 8.4 | 115.5 | 16.84 | 1 |
| 2026-07 | 33 | 2328.60 | 70.56 | 16.4 | 18.9 | 123.53 | 0 |

## TP Target Distribution

| Target | Trades | PnL | Avg PnL | Median Hold Min |
| --- | ---: | ---: | ---: | ---: |
| 2.34 | 1 | 81.60 | 81.60 | 3.0 |
| 2.40 | 23 | 850.00 | 36.96 | 3.0 |
| 2.63 | 1 | 38.50 | 38.50 | 12.0 |
| 2.75 | 1 | 37.40 | 37.40 | 349.7 |
| 3.00 | 13 | 746.70 | 57.44 | 16.5 |
| 3.02 | 1 | 35.00 | 35.00 | 90.2 |
| 3.05 | 1 | 115.60 | 115.60 | 6.2 |
| 3.09 | 1 | 52.70 | 52.70 | 11.9 |
| 3.22 | 2 | 149.50 | 74.75 | 138.1 |
| 3.26 | 2 | 149.50 | 74.75 | 9.4 |
| 3.30 | 1 | 115.50 | 115.50 | 0.1 |
| 3.31 | 1 | 34.00 | 34.00 | 19.1 |
| 3.38 | 1 | 45.50 | 45.50 | 12.6 |
| 3.44 | 1 | 115.60 | 115.60 | 7.3 |
| 3.47 | 2 | 153.00 | 76.50 | 13.3 |
| 3.53 | 1 | 119.00 | 119.00 | 8.4 |
| 3.56 | 1 | 35.00 | 35.00 | 15.6 |
| 3.58 | 1 | 35.00 | 35.00 | 23.6 |
| 3.60 | 7 | 606.90 | 86.70 | 11.4 |
| 4.00 | 3 | 103.70 | 34.57 | 26.0 |
| 6.00 | 1 | 35.00 | 35.00 | 81.9 |
| 12.00 | 1 | 437.50 | 437.50 | 198.3 |
| 14.06 | 1 | 34.00 | 34.00 | 12.1 |
| 15.00 | 1 | 44.20 | 44.20 | 44.6 |
| 16.25 | 1 | 34.00 | 34.00 | 23.6 |
| 23.75 | 1 | 34.00 | 34.00 | 57.7 |
| 48.62 | 1 | 35.00 | 35.00 | 25.7 |

## Slow Trade Fingerprint
- Trades held >= 12 hours: 1 (1.4%)
- Slow-trade median hold: 5775.0 minutes
- Slow-trade total PnL: 34.00
- rsi14: slow median 80.41, fast<15m median 51.27
- adx14: slow median 31.17, fast<15m median 20.13
- es_minus_vwap: slow median 4.54, fast<15m median 9.03
- price_minus_ema20: slow median -4.41, fast<15m median -56.98
- es_structure_score: slow median 3.00, fast<15m median 4.00
- es_structure_pullback_from_high: slow median 10.00, fast<15m median 2.75
- es_structure_higher_low_distance: slow median 13.25, fast<15m median 0.62
- es_structure_higher_high_distance: slow median 8.25, fast<15m median 1.12
- es_structure_vwap_distance: slow median 4.54, fast<15m median 9.03
- es_vwap_acceleration: slow median 0.01, fast<15m median -0.00
- es_rolling_high_distance: slow median 10.00, fast<15m median 4.00
- es_rolling_high_minutes_since: slow median 2.55, fast<15m median 7.22
- rsi_slope: slow median 1.91, fast<15m median 0.81
- adx_slope: slow median 1.35, fast<15m median 0.16
- setup_quality_score: slow median 63.31, fast<15m median 58.93
- setup_quality_take_profit_boost: slow median 0.18, fast<15m median 0.00
- entry_veto_points: slow median 4.00, fast<15m median 3.00
- slow_risk_points: slow median 0.00, fast<15m median 0.00
- es_reclaim_current_distance: slow median 4.54, fast<15m median 9.03
- spx_ema20_distance: slow median -0.01, fast<15m median -0.33

## Interpretation Notes
- This strategy exits with take-profit orders only, so a high win rate can hide capital being tied up for a long time.
- The best setting candidates are usually found by reducing slow-to-profit entries, not simply maximizing raw entry count.
- Focus first on buckets with low average PnL or long median hold time, then test stricter RSI/ADX/VWAP/VIX filters against those buckets.
