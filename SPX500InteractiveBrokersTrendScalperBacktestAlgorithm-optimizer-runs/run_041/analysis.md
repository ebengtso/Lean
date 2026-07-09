# SPX500 IB Trend Scalper Analysis

- Metrics file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_041/execution-metrics.csv`
- Backtest file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_041/launcher/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm.json`
- Completed paired trades: 111
- Entry signals: 111
- Approx open/unpaired entry signals: 0
- Position/order maintenance waits: 7852
- Total paired trade PnL: 7002.90
- Win rate: 100.0%
- Realized loss trades: 0
- Median hold: 12.0 minutes
- Average hold: 18.4 minutes

## Lean Runtime Statistics
- Equity: $107,002.90
- Net Profit: $7,002.90
- Return: 7.00 %
- Probabilistic Sharpe Ratio: 100.000%
- Volume: $47,982,644.90

## Risk And Efficiency
- Exposure hours: 34.0
- PnL per exposure hour: 206.23
- Calendar span days: 12.3
- PnL per calendar day: 568.53
- Trades per calendar day: 9.01
- Exposure share of calendar time: 11.5%
- Growth quality score: 11049.6
- VIX stale at entry: 0.0%
- ES stale rows: 9.6%
- Waiting ES VWAP rows: 0.0%
- Trade-health exit signals: 0
- Trade-health tighten signals: 0
- Slow trades held >= 12 hours: 0 (0.0%)
- Slow exposure hours: 0.0
- Slow PnL per exposure hour: 
- Fast <15m trades: 70
- Fast PnL per exposure hour: 711.45

## Pullback Broken Structure Veto
- Blocked signal rows: 1314
- Blocked by profile: `{"charm_pin_pullback_long": 1262, "pullback_long": 52}`
- Blocked net profit / worst MAE: not available for hard-blocked signals because they do not become completed trades.
- Remaining trades by profile: `{"breakout_long_1dte": 20, "breakout_long_no_0dte": 3, "call_wall_acceptance_long": 1, "charm_pin_pullback_long": 38, "charm_wall_breakaway_long": 3, "pullback_long": 33, "pullback_long_no_0dte": 3, "squeeze_long": 10}`
- Remaining PnL by profile: `{"breakout_long_1dte": 1310.1999999999916, "breakout_long_no_0dte": 278.40000000001237, "call_wall_acceptance_long": 91.0, "charm_pin_pullback_long": 1497.9000000001333, "charm_wall_breakaway_long": 446.2000000000007, "pullback_long": 2566.400000000218, "pullback_long_no_0dte": 91.79999999999018, "squeeze_long": 721.0000000000064}`

## Lean Portfolio And Trade Statistics
- Portfolio: sharpeRatio=32.4451, sortinoRatio=0, alpha=0, beta=0, informationRatio=33.0750, drawdown=0.004
- Trades: sharpeRatio=1.2462, averageMAE=-98.9167, averageMFE=81.4703, largestMAE=-513.4, largestMFE=363.6, maximumIntraTradeDrawdown=-564.4

## Strategy Profile Performance

| Strategy | Enabled | Data State | Profile Set | Trades | PnL | Avg PnL | Win Rate | Median Hold Min | Exposure Hrs | PnL/Exposure Hr | Slow >=12h | Worst MAE | Median MFE | Median TP |
| --- | --- | --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| pullback_long | true | VALID_0DTE | VALID_0DTE | 33 | 2566.40 | 77.77 | 100.0% | 12.0 | 10.7 | 239.87 | 0 | -403.20 | 98.00 | 3.33 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 38 | 1497.90 | 39.42 | 100.0% | 5.0 | 7.4 | 202.27 | 0 | -513.40 | 42.50 | 2.40 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 1310.20 | 65.51 | 100.0% | 14.1 | 7.7 | 169.43 | 0 | -375.70 | 79.88 | 3.00 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 10 | 721.00 | 72.10 | 100.0% | 15.7 | 3.9 | 187.16 | 0 | -208.25 | 77.78 | 33.59 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 3 | 446.20 | 148.73 | 100.0% | 16.6 | 1.0 | 462.12 | 0 | -346.80 | 146.20 | 10.00 |
| breakout_long_no_0dte | true | EXPIRED_0DTE | EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 | 0.2 | 845.57 | 0 | -76.50 | 243.10 | 6.00 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 3 | 91.80 | 30.60 | 100.0% | 16.4 | 1.1 | 83.22 | 0 | -103.50 | 27.90 | 4.00 |
| call_wall_acceptance_long | true | VALID_0DTE | VALID_0DTE | 1 | 91.00 | 91.00 | 100.0% | 12.0 | 0.2 | 455.00 | 0 | -11.70 | 131.30 | 28.66 |
| breakout_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 2 | 71.00 | 35.50 | 100.0% | 52.6 | 1.8 | 40.51 | 0 | -250.25 | 62.27 | 6.00 |
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
| pullback_long | true | VALID_0DTE | VALID_0DTE | 33 | 50.12 | 6.44 | 48.61 | 20.59 | 19.5 | 0 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 38 | 66.78 | 29.42 | 49.07 | 20.76 | 11.7 | 0 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 66.60 | 5.83 | 70.56 | 26.99 | 23.2 | 0 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 10 | 69.16 | 11.21 | 69.11 | 21.34 | 23.1 | 0 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 3 | 66.74 | 13.23 | 56.56 | 17.35 | 19.3 | 0 |
| breakout_long_no_0dte | true | EXPIRED_0DTE | EXPIRED_0DTE | 1 | 70.88 | 7.38 | 81.57 | 27.17 | 14.7 | 0 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 3 | 54.55 | 5.48 | 48.15 | 19.52 | 22.1 | 0 |
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
- MAE: average -99.82, median -65.05, worst -513.40
- MFE: average 81.47, median 61.25, best 363.60
- Average MFE / absolute MAE: 0.82

## Intratrade Path
- Trades with path stats: 111; with intratrade price samples: 111
- Went positive before max adverse: 52.3%
- MFE happened before MAE: 9.9%
- TP touched before MAE: 0.9%
- Median MFE available before MAE: 0.05 points
- Median first TP touch: 3.0 minutes
- Median first +1.5 points: 2.9 minutes
- First 15m MFE/MAE medians: 2.40 / -1.90 points

## Worst Tail Trade Autopsy
- Worst tail entry: `2026-06-26T12:36:24+00:00` -> `2026-06-26T13:56:26+00:00`.
- Strategy/profile: `charm_pin_pullback_long` / `charm_pin_pullback_long`. PnL 42.50, MAE -513.40, MFE 51.00, hold 80.0 minutes.
- Profile context: `charm_pin_pullback_long` produced 38 trades, PnL 1497.90, 0 slow >=12h trades, and 21.4% of total PnL.
- Entry state: setup=61.77, ES-VWAP=26.69, VWAP slope=0.0417, VWAP acceleration=-0.0179, RSI=42.42, ADX=17.95, structure score=4.00, higher-low=0.2500, higher-high=3.75, pullback-from-high=9.25, rolling-high distance=14.25.
- Guard state: setup allowed=`True`, entry veto allowed=`True`, veto points=4.00, slow-risk points=0.00.
- Existing warning reason: ES pullback from high 9.25 >= 5.00; RSI slope -3.8597 <= -2.0000; ADX 17.95 <= 18.00; RSI 42.42 <= 45.00.
- Strategy selection reason: positive gamma/charm pin pullback: expectedMovePosition=0.0105, netCharm30m=-25186308, lowerFade=False, pullback=True, dynamicMaxVwapDistance=17.89.
- Intratrade path: path MFE 2.50, path MAE -27.70, MFE before MAE=`False`, TP reached=`True`.
- Surgical setup floor check: `setup_quality_score >= 61.8` would block this trade, keep 53 trades, retain 42.4% PnL, and leave worst MAE -375.70. It would block 58 trades total.
- No single candidate threshold in the report cleanly removes this tail; the closest visible guard is setup quality 61.77.

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
| `es_structure_rising_vwap != "False"` | 22 | 7 | 13 | 91 | 5520.20 | 1482.70 | 78.8% | -513.40 | 12397.8 |
| `long_strategy != "breakout_long_1dte"` | 22 | 6 | 14 | 91 | 5692.70 | 1310.20 | 81.3% | -513.40 | 12364.6 |
| `strategy_profile != "breakout_long_1dte"` | 22 | 6 | 14 | 91 | 5692.70 | 1310.20 | 81.3% | -513.40 | 12364.6 |
| `path_half_tp_touch_minutes >= 0.183333` | 22 | 13 | 22 | 76 | 5256.50 | 1746.40 | 75.1% | -513.40 | 479.9 |
| `option_strike_map_target_1_strike >= 7475` | 22 | 6 | 10 | 95 | 5879.30 | 1123.60 | 84.0% | -403.20 | 164.6 |
| `es_rolling_high_samples <= 1751` | 22 | 5 | 11 | 95 | 6206.20 | 796.70 | 88.6% | -513.40 | 158.3 |
| `es_reclaim_samples <= 585` | 22 | 6 | 14 | 91 | 5776.40 | 1226.50 | 82.5% | -513.40 | 140.0 |
| `option_strike_map_target_1_strike >= 7500` | 22 | 7 | 26 | 78 | 5262.20 | 1740.70 | 75.1% | -403.20 | 93.1 |
| `es_reclaim_samples <= 590` | 22 | 5 | 13 | 93 | 5835.90 | 1167.00 | 83.3% | -513.40 | 88.6 |
| `es_structure_higher_low_distance >= -1` | 22 | 6 | 20 | 85 | 5500.80 | 1502.10 | 78.6% | -513.40 | 81.4 |
| `path_first_observed_points <= 0.05` | 22 | 5 | 17 | 89 | 5782.30 | 1220.60 | 82.6% | -403.20 | 73.0 |
| `option_strike_map_target_2_strike <= 7599.55` | 22 | 6 | 19 | 86 | 5424.90 | 1578.00 | 77.5% | -513.40 | 69.3 |

## Upside TP Extension Candidates
| all | No upside TP extension candidates found. |  |  |  |  |  |  |  |  |  |  |

## Event Counts
- blocked: 36427
- position_wait: 7852
- stale_es_vwap: 4867
- trade_risk_tighten_signal: 573
- order_event: 499
- waiting_spx_quote: 414
- entry_signal: 111

## Blocked Gate Counts
- setup_quality_allowed: 14679 (disabled=14679)
- above_vwap_confirmed: 9368 (disabled=9368)
- above_vwap: 8354 (disabled=8354)
- es_structure_allowed: 8091 (disabled=8091)
- pullback: 6662 (disabled=6662)
- momentum: 4377 (disabled=4377)
- es_vwap_max_distance_allowed: 4032 (disabled=4032)
- es_vwap_slope_allowed: 3718 (disabled=3718)
- trend_strength: 3357 (disabled=3357)
- es_vwap_acceleration_allowed: 1957 (disabled=1957)
- es_rolling_high_allowed: 537 (disabled=537)
- indicator_slope_allowed: 173 (disabled=173)

## By UTC Hour

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 13 | 12 | 728.40 | 60.70 | 100.0% | 0.4 |
| 8 | 11 | 1218.30 | 110.75 | 100.0% | 16.6 |
| 14 | 10 | 472.70 | 47.27 | 100.0% | 1.5 |
| 12 | 8 | 353.30 | 44.16 | 100.0% | 12.1 |
| 9 | 8 | 438.40 | 54.80 | 100.0% | 12.0 |
| 15 | 7 | 452.10 | 64.59 | 100.0% | 6.5 |
| 1 | 6 | 515.30 | 85.88 | 100.0% | 3.0 |
| 18 | 6 | 337.60 | 56.27 | 100.0% | 10.4 |
| 11 | 5 | 178.20 | 35.64 | 100.0% | 12.0 |
| 19 | 5 | 276.20 | 55.24 | 100.0% | 8.4 |
| 5 | 5 | 245.10 | 49.02 | 100.0% | 20.6 |
| 6 | 5 | 243.10 | 48.62 | 100.0% | 16.4 |
| 2 | 4 | 214.50 | 53.63 | 100.0% | 48.6 |
| 22 | 4 | 392.90 | 98.23 | 100.0% | 14.9 |
| 7 | 4 | 241.70 | 60.42 | 100.0% | 12.0 |
| 0 | 3 | 174.40 | 58.13 | 100.0% | 12.1 |
| 10 | 3 | 181.20 | 60.40 | 100.0% | 14.0 |
| 23 | 2 | 70.00 | 35.00 | 100.0% | 29.5 |
| 3 | 2 | 150.50 | 75.25 | 100.0% | 15.9 |
| 17 | 1 | 119.00 | 119.00 | 100.0% | 7.3 |

## By RSI Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <55 | 61 | 3727.60 | 61.11 | 100.0% | 7.3 |
| 55-60 | 17 | 1256.40 | 73.91 | 100.0% | 14.0 |
| >=75 | 11 | 1012.60 | 92.05 | 100.0% | 9.9 |
| 70-75 | 9 | 448.00 | 49.78 | 100.0% | 20.0 |
| 60-65 | 8 | 395.50 | 49.44 | 100.0% | 27.6 |
| 65-70 | 5 | 162.80 | 32.56 | 100.0% | 16.4 |

## By ADX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <20 | 44 | 2957.60 | 67.22 | 100.0% | 9.2 |
| 20-25 | 22 | 1311.00 | 59.59 | 100.0% | 12.1 |
| 25-30 | 20 | 1228.10 | 61.41 | 100.0% | 12.1 |
| 30-40 | 19 | 1164.80 | 61.31 | 100.0% | 12.0 |
| 40-50 | 5 | 301.80 | 60.36 | 100.0% | 12.0 |
| >=50 | 1 | 39.60 | 39.60 | 100.0% | 17.0 |

## By VIX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| missing | 111 | 7002.90 | 63.09 | 100.0% | 12.0 |

## By ES VWAP Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.25 | 106 | 6764.60 | 63.82 | 100.0% | 12.0 |
| 0.25-0.5 | 3 | 185.30 | 61.77 | 100.0% | 5.8 |
| -0.25-0 | 1 | 36.00 | 36.00 | 100.0% | 56.0 |
| 0.5-1 | 1 | 17.00 | 17.00 | 100.0% | 29.9 |

## By ES VWAP Acceleration Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.05 | 51 | 3227.70 | 63.29 | 100.0% | 12.0 |
| -0.05-0 | 38 | 2389.00 | 62.87 | 100.0% | 7.8 |
| 0.1-0.25 | 10 | 658.50 | 65.85 | 100.0% | 15.7 |
| 0.05-0.1 | 6 | 287.40 | 47.90 | 100.0% | 20.5 |
| -0.1--0.05 | 2 | 215.80 | 107.90 | 100.0% | 10.8 |
| >=0.25 | 2 | 53.00 | 26.50 | 100.0% | 55.9 |
| -0.25--0.1 | 1 | 87.50 | 87.50 | 100.0% | 6.7 |
| <-0.25 | 1 | 84.00 | 84.00 | 100.0% | 2.4 |

## By ES Rolling High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-6 | 29 | 1498.70 | 51.68 | 100.0% | 5.8 |
| 2-4 | 23 | 1253.50 | 54.50 | 100.0% | 15.3 |
| 0-1 | 19 | 1605.10 | 84.48 | 100.0% | 13.2 |
| 6-8 | 14 | 966.60 | 69.04 | 100.0% | 10.3 |
| 12-20 | 9 | 789.20 | 87.69 | 100.0% | 6.6 |
| 8-12 | 9 | 418.60 | 46.51 | 100.0% | 12.0 |
| 1-2 | 6 | 400.20 | 66.70 | 100.0% | 18.6 |
| >=20 | 2 | 71.00 | 35.50 | 100.0% | 37.6 |

## By ES Rolling High Minutes Since

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 20-30 | 37 | 2484.00 | 67.14 | 100.0% | 8.7 |
| <1 | 23 | 1793.80 | 77.99 | 100.0% | 14.7 |
| 5-10 | 14 | 923.30 | 65.95 | 100.0% | 9.2 |
| 1-3 | 13 | 566.40 | 43.57 | 100.0% | 17.3 |
| 10-20 | 13 | 667.40 | 51.34 | 100.0% | 12.0 |
| 3-5 | 10 | 501.50 | 50.15 | 100.0% | 10.2 |
| 30-60 | 1 | 66.50 | 66.50 | 100.0% | 12.0 |

## By RSI Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| >=3 | 34 | 2214.40 | 65.13 | 100.0% | 12.0 |
| 0-1 | 22 | 1143.30 | 51.97 | 100.0% | 6.0 |
| <-3 | 10 | 440.30 | 44.03 | 100.0% | 9.3 |
| -1-0 | 9 | 612.30 | 68.03 | 100.0% | 12.0 |
| -3--2 | 8 | 323.80 | 40.48 | 100.0% | 6.8 |
| 1-2 | 8 | 613.80 | 76.73 | 100.0% | 13.5 |
| -2--1 | 7 | 507.40 | 72.49 | 100.0% | 12.0 |
| 2-3 | 7 | 706.20 | 100.89 | 100.0% | 15.6 |
| missing | 6 | 441.40 | 73.57 | 100.0% | 8.4 |

## By ADX Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-1 | 39 | 2265.10 | 58.08 | 100.0% | 11.9 |
| -1-0 | 38 | 2671.20 | 70.29 | 100.0% | 12.3 |
| 1-2 | 20 | 1324.80 | 66.24 | 100.0% | 7.8 |
| -2--1 | 8 | 300.40 | 37.55 | 100.0% | 21.3 |
| missing | 6 | 441.40 | 73.57 | 100.0% | 8.4 |

## By ES Higher-Low Distance Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 2-4 | 34 | 1825.40 | 53.69 | 100.0% | 12.3 |
| 4-8 | 22 | 1895.60 | 86.16 | 100.0% | 10.9 |
| 1-2 | 21 | 1154.60 | 54.98 | 100.0% | 8.4 |
| >=8 | 17 | 1240.80 | 72.99 | 100.0% | 14.7 |
| 0-0.5 | 10 | 466.20 | 46.62 | 100.0% | 4.5 |
| 0.5-1 | 7 | 420.30 | 60.04 | 100.0% | 11.9 |

## By ES Structure Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4 | 40 | 2662.00 | 66.55 | 100.0% | 12.0 |
| 3 | 39 | 2438.60 | 62.53 | 100.0% | 12.0 |
| 5 | 31 | 1868.30 | 60.27 | 100.0% | 11.9 |
| 2 | 1 | 34.00 | 34.00 | 100.0% | 12.1 |

## By ES Structure Pullback From High

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-2 | 47 | 3607.60 | 76.76 | 100.0% | 12.1 |
| 2-4 | 30 | 1660.70 | 55.36 | 100.0% | 11.9 |
| 4-8 | 25 | 1189.70 | 47.59 | 100.0% | 7.2 |
| 8-12 | 6 | 245.10 | 40.85 | 100.0% | 14.7 |
| 12-16 | 2 | 174.00 | 87.00 | 100.0% | 6.0 |
| 16-24 | 1 | 125.80 | 125.80 | 100.0% | 11.9 |

## By ES Structure Higher-Low Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 41 | 2496.10 | 60.88 | 100.0% | 12.0 |
| 2-4 | 17 | 636.50 | 37.44 | 100.0% | 20.0 |
| 1-2 | 13 | 1022.30 | 78.64 | 100.0% | 11.9 |
| 0.5-1 | 12 | 987.20 | 82.27 | 100.0% | 4.8 |
| 4-8 | 11 | 565.10 | 51.37 | 100.0% | 9.9 |
| >=8 | 9 | 717.50 | 79.72 | 100.0% | 12.0 |
| 0-0.5 | 8 | 578.20 | 72.28 | 100.0% | 10.8 |

## By ES Structure Higher-High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 41 | 2706.00 | 66.00 | 100.0% | 8.7 |
| 2-4 | 18 | 923.10 | 51.28 | 100.0% | 3.7 |
| 1-2 | 16 | 988.50 | 61.78 | 100.0% | 16.0 |
| 4-8 | 16 | 1134.50 | 70.91 | 100.0% | 12.1 |
| >=8 | 9 | 560.00 | 62.22 | 100.0% | 14.7 |
| 0-0.5 | 7 | 437.90 | 62.56 | 100.0% | 16.4 |
| 0.5-1 | 4 | 252.90 | 63.23 | 100.0% | 10.4 |

## By ES Structure VWAP Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 38 | 2671.90 | 70.31 | 100.0% | 13.9 |
| >=24 | 29 | 1031.90 | 35.58 | 100.0% | 2.8 |
| 8-12 | 15 | 1534.80 | 102.32 | 100.0% | 23.3 |
| 12-16 | 9 | 600.10 | 66.68 | 100.0% | 12.0 |
| 2-4 | 9 | 626.80 | 69.64 | 100.0% | 12.0 |
| 16-24 | 7 | 312.50 | 44.64 | 100.0% | 8.4 |
| 0-2 | 4 | 224.90 | 56.22 | 100.0% | 11.9 |

## By Setup Quality Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 50-60 | 37 | 2631.40 | 71.12 | 100.0% | 8.4 |
| 60-70 | 26 | 1399.10 | 53.81 | 100.0% | 12.0 |
| 70-80 | 20 | 1177.10 | 58.86 | 100.0% | 12.0 |
| 40-50 | 17 | 1244.20 | 73.19 | 100.0% | 12.7 |
| 80-90 | 11 | 551.10 | 50.10 | 100.0% | 16.6 |

## By Entry-Veto Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 1-2 | 24 | 1693.50 | 70.56 | 100.0% | 12.1 |
| 3-4 | 23 | 1447.60 | 62.94 | 100.0% | 11.9 |
| 2-3 | 22 | 1051.20 | 47.78 | 100.0% | 13.8 |
| 5-6 | 17 | 989.90 | 58.23 | 100.0% | 7.3 |
| 4-5 | 16 | 1075.40 | 67.21 | 100.0% | 8.8 |
| <1 | 9 | 745.30 | 82.81 | 100.0% | 12.0 |

## By Slow-Risk Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <1 | 111 | 7002.90 | 63.09 | 100.0% | 12.0 |

## By Entry Risk Tier

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| standard | 111 | 7002.90 | 63.09 | 100.0% | 12.0 |

## By ES Reclaim Current Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 38 | 2671.90 | 70.31 | 100.0% | 13.9 |
| >=24 | 29 | 1031.90 | 35.58 | 100.0% | 2.8 |
| 8-12 | 15 | 1534.80 | 102.32 | 100.0% | 23.3 |
| 12-16 | 9 | 600.10 | 66.68 | 100.0% | 12.0 |
| 2-4 | 9 | 626.80 | 69.64 | 100.0% | 12.0 |
| 16-24 | 7 | 312.50 | 44.64 | 100.0% | 8.4 |
| 0-2 | 4 | 224.90 | 56.22 | 100.0% | 11.9 |

## By SPX EMA20 Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 74 | 4156.10 | 56.16 | 100.0% | 8.6 |
| 2-4 | 13 | 1109.30 | 85.33 | 100.0% | 24.9 |
| 4-6 | 8 | 586.60 | 73.33 | 100.0% | 10.9 |
| 8-12 | 5 | 650.10 | 130.02 | 100.0% | 12.1 |
| 1-2 | 4 | 142.00 | 35.50 | 100.0% | 54.7 |
| >=12 | 4 | 197.80 | 49.45 | 100.0% | 20.0 |
| 6-8 | 2 | 70.00 | 35.00 | 100.0% | 40.7 |
| 0-1 | 1 | 91.00 | 91.00 | 100.0% | 12.0 |

## By Hold-Time Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 5-15 | 40 | 3261.70 | 81.54 | 100.0% | 11.9 |
| <5 | 30 | 2052.60 | 68.42 | 100.0% | 1.4 |
| 15-30 | 28 | 1220.10 | 43.58 | 100.0% | 20.3 |
| 60-180 | 7 | 264.00 | 37.71 | 100.0% | 90.2 |
| 30-60 | 6 | 204.50 | 34.08 | 100.0% | 41.3 |

## By VIX Regime

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| disabled | 111 | 7002.90 | 63.09 | 100.0% | 12.0 |

## By Option Data State

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 85 | 5322.50 | 62.62 | 100.0% | 11.9 |
| VALID_1DTE_ONLY | 20 | 1310.20 | 65.51 | 100.0% | 14.1 |
| STALE_0DTE | 5 | 162.80 | 32.56 | 100.0% | 23.3 |
| EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 |

## By Active Profile Set

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 85 | 5322.50 | 62.62 | 100.0% | 11.9 |
| VALID_1DTE_ONLY | 20 | 1310.20 | 65.51 | 100.0% | 14.1 |
| STALE_0DTE | 5 | 162.80 | 32.56 | 100.0% | 23.3 |
| EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 |

## Monthly Summary

| Month | Trades | PnL | Avg PnL | Median Hold Min | Exposure Hours | PnL/Exposure Hour | Slow >=12h |
| --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| 2026-06 | 70 | 4165.60 | 59.51 | 9.3 | 16.1 | 258.91 | 0 |
| 2026-07 | 41 | 2837.30 | 69.20 | 13.2 | 17.9 | 158.79 | 0 |

## TP Target Distribution

| Target | Trades | PnL | Avg PnL | Median Hold Min |
| --- | ---: | ---: | ---: | ---: |
| 2.34 | 1 | 84.00 | 84.00 | 3.0 |
| 2.40 | 38 | 1497.90 | 39.42 | 5.0 |
| 2.49 | 1 | 45.50 | 45.50 | 20.6 |
| 2.57 | 1 | 93.60 | 93.60 | 5.3 |
| 2.63 | 1 | 39.60 | 39.60 | 12.0 |
| 2.83 | 1 | 36.00 | 36.00 | 56.0 |
| 2.99 | 1 | 105.00 | 105.00 | 8.5 |
| 3.00 | 20 | 1310.20 | 65.51 | 14.1 |
| 3.02 | 2 | 147.60 | 73.80 | 49.9 |
| 3.09 | 1 | 55.80 | 55.80 | 11.9 |
| 3.13 | 1 | 59.50 | 59.50 | 12.0 |
| 3.14 | 1 | 108.50 | 108.50 | 6.5 |
| 3.19 | 1 | 35.00 | 35.00 | 26.0 |
| 3.22 | 1 | 118.80 | 118.80 | 6.6 |
| 3.26 | 1 | 118.80 | 118.80 | 3.8 |
| 3.30 | 1 | 118.80 | 118.80 | 0.1 |
| 3.31 | 2 | 69.00 | 34.50 | 17.2 |
| 3.33 | 1 | 36.00 | 36.00 | 29.9 |
| 3.34 | 1 | 36.00 | 36.00 | 155.4 |
| 3.35 | 1 | 119.00 | 119.00 | 8.4 |
| 3.43 | 1 | 46.80 | 46.80 | 12.7 |
| 3.44 | 1 | 119.00 | 119.00 | 7.3 |
| 3.46 | 1 | 136.50 | 136.50 | 8.8 |
| 3.48 | 1 | 122.50 | 122.50 | 5.8 |
| 3.51 | 1 | 35.00 | 35.00 | 17.4 |
| 3.56 | 1 | 36.00 | 36.00 | 15.6 |
| 3.58 | 1 | 36.00 | 36.00 | 23.6 |
| 3.60 | 7 | 663.90 | 94.84 | 11.9 |
| 4.00 | 2 | 36.00 | 18.00 | 27.2 |
| 6.00 | 3 | 278.40 | 92.80 | 23.3 |
| 10.00 | 3 | 446.20 | 148.73 | 16.6 |
| 14.06 | 1 | 34.00 | 34.00 | 12.1 |
| 15.00 | 1 | 45.50 | 45.50 | 44.6 |
| 16.25 | 1 | 35.00 | 35.00 | 23.6 |
| 23.75 | 1 | 35.00 | 35.00 | 57.7 |
| 28.44 | 1 | 112.20 | 112.20 | 12.0 |
| 28.66 | 1 | 91.00 | 91.00 | 12.0 |
| 38.75 | 2 | 125.80 | 62.90 | 14.7 |
| 48.62 | 2 | 71.00 | 35.50 | 19.9 |
| 55.78 | 1 | 262.50 | 262.50 | 12.0 |

## Slow Trade Fingerprint
- Trades held >= 12 hours: 0 (0.0%)

## Interpretation Notes
- This strategy exits with take-profit orders only, so a high win rate can hide capital being tied up for a long time.
- The best setting candidates are usually found by reducing slow-to-profit entries, not simply maximizing raw entry count.
- Focus first on buckets with low average PnL or long median hold time, then test stricter RSI/ADX/VWAP/VIX filters against those buckets.
