# SPX500 IB Trend Scalper Analysis

- Metrics file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_039/execution-metrics.csv`
- Backtest file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_039/launcher/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm.json`
- Completed paired trades: 106
- Entry signals: 106
- Approx open/unpaired entry signals: 0
- Position/order maintenance waits: 8113
- Total paired trade PnL: 6880.50
- Win rate: 100.0%
- Realized loss trades: 0
- Median hold: 12.0 minutes
- Average hold: 19.8 minutes

## Lean Runtime Statistics
- Equity: $106,880.50
- Net Profit: $6,880.50
- Return: 6.88 %
- Probabilistic Sharpe Ratio: 100.000%
- Volume: $46,125,114.50

## Risk And Efficiency
- Exposure hours: 35.0
- PnL per exposure hour: 196.32
- Calendar span days: 12.3
- PnL per calendar day: 558.59
- Trades per calendar day: 8.61
- Exposure share of calendar time: 11.9%
- Growth quality score: 10901.8
- VIX stale at entry: 0.0%
- ES stale rows: 9.4%
- Waiting ES VWAP rows: 0.0%
- Trade-health exit signals: 0
- Trade-health tighten signals: 0
- Slow trades held >= 12 hours: 0 (0.0%)
- Slow exposure hours: 0.0
- Slow PnL per exposure hour: 
- Fast <15m trades: 67
- Fast PnL per exposure hour: 731.26

## Pullback Broken Structure Veto
- Blocked signal rows: 1086
- Blocked by profile: `{"charm_pin_pullback_long": 1034, "pullback_long": 52}`
- Blocked net profit / worst MAE: not available for hard-blocked signals because they do not become completed trades.
- Remaining trades by profile: `{"breakout_long_1dte": 20, "breakout_long_no_0dte": 3, "call_wall_acceptance_long": 1, "charm_pin_pullback_long": 34, "charm_wall_breakaway_long": 3, "pullback_long": 32, "pullback_long_no_0dte": 3, "squeeze_long": 10}`
- Remaining PnL by profile: `{"breakout_long_1dte": 1310.1999999999916, "breakout_long_no_0dte": 278.40000000001237, "call_wall_acceptance_long": 91.0, "charm_pin_pullback_long": 1325.1000000001459, "charm_wall_breakaway_long": 532.5999999999876, "pullback_long": 2530.400000000218, "pullback_long_no_0dte": 91.79999999999018, "squeeze_long": 721.0000000000064}`

## Lean Portfolio And Trade Statistics
- Portfolio: sharpeRatio=31.9428, sortinoRatio=0, alpha=0, beta=0, informationRatio=32.5840, drawdown=0.004
- Trades: sharpeRatio=1.1483, averageMAE=-100.2170, averageMFE=83.3288, largestMAE=-513.4, largestMFE=462.60, maximumIntraTradeDrawdown=-564.4

## Strategy Profile Performance

| Strategy | Enabled | Data State | Profile Set | Trades | PnL | Avg PnL | Win Rate | Median Hold Min | Exposure Hrs | PnL/Exposure Hr | Slow >=12h | Worst MAE | Median MFE | Median TP |
| --- | --- | --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| pullback_long | true | VALID_0DTE | VALID_0DTE | 32 | 2530.40 | 79.08 | 100.0% | 12.0 | 9.8 | 259.11 | 0 | -403.20 | 102.10 | 3.33 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 34 | 1325.10 | 38.97 | 100.0% | 3.8 | 6.6 | 200.35 | 0 | -513.40 | 42.50 | 2.40 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 1310.20 | 65.51 | 100.0% | 14.1 | 7.7 | 169.43 | 0 | -375.70 | 79.88 | 3.00 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 10 | 721.00 | 72.10 | 100.0% | 15.7 | 3.9 | 187.16 | 0 | -208.25 | 77.78 | 33.59 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 3 | 532.60 | 177.53 | 100.0% | 16.6 | 3.8 | 140.82 | 0 | -346.80 | 146.20 | 12.00 |
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
| pullback_long | true | VALID_0DTE | VALID_0DTE | 32 | 50.21 | 6.57 | 48.90 | 20.37 | 18.3 | 0 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 34 | 66.16 | 29.55 | 49.67 | 19.65 | 11.7 | 0 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 66.60 | 5.83 | 70.56 | 26.99 | 23.2 | 0 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 10 | 69.16 | 11.21 | 69.11 | 21.34 | 23.1 | 0 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 3 | 66.74 | 13.23 | 56.56 | 17.35 | 75.6 | 0 |
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
- MAE: average -101.17, median -70.20, worst -513.40
- MFE: average 83.33, median 62.12, best 462.60
- Average MFE / absolute MAE: 0.82

## Intratrade Path
- Trades with path stats: 106; with intratrade price samples: 106
- Went positive before max adverse: 52.8%
- MFE happened before MAE: 9.4%
- TP touched before MAE: 0.9%
- Median MFE available before MAE: 0.05 points
- Median first TP touch: 2.8 minutes
- Median first +1.5 points: 2.9 minutes
- First 15m MFE/MAE medians: 2.40 / -1.85 points

## Worst Tail Trade Autopsy
- Worst tail entry: `2026-06-26T12:36:24+00:00` -> `2026-06-26T13:56:26+00:00`.
- Strategy/profile: `charm_pin_pullback_long` / `charm_pin_pullback_long`. PnL 42.50, MAE -513.40, MFE 51.00, hold 80.0 minutes.
- Profile context: `charm_pin_pullback_long` produced 34 trades, PnL 1325.10, 0 slow >=12h trades, and 19.3% of total PnL.
- Entry state: setup=61.77, ES-VWAP=26.69, VWAP slope=0.0417, VWAP acceleration=-0.0179, RSI=42.42, ADX=17.95, structure score=4.00, higher-low=0.2500, higher-high=3.75, pullback-from-high=9.25, rolling-high distance=14.25.
- Guard state: setup allowed=`True`, entry veto allowed=`True`, veto points=4.00, slow-risk points=0.00.
- Existing warning reason: ES pullback from high 9.25 >= 5.00; RSI slope -3.8597 <= -2.0000; ADX 17.95 <= 18.00; RSI 42.42 <= 45.00.
- Strategy selection reason: positive gamma/charm pin pullback: expectedMovePosition=0.0105, netCharm30m=-25186308, lowerFade=False, pullback=True, dynamicMaxVwapDistance=17.89.
- Intratrade path: path MFE 2.50, path MAE -27.70, MFE before MAE=`False`, TP reached=`True`.
- Surgical setup floor check: `setup_quality_score >= 61.8` would block this trade, keep 50 trades, retain 41.9% PnL, and leave worst MAE -375.70. It would block 56 trades total.
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
| `es_structure_rising_vwap != "False"` | 21 | 7 | 13 | 86 | 5397.80 | 1482.70 | 78.5% | -513.40 | 12415.9 |
| `long_strategy != "breakout_long_1dte"` | 21 | 6 | 14 | 86 | 5570.30 | 1310.20 | 81.0% | -513.40 | 12379.4 |
| `strategy_profile != "breakout_long_1dte"` | 21 | 6 | 14 | 86 | 5570.30 | 1310.20 | 81.0% | -513.40 | 12379.4 |
| `path_half_tp_touch_minutes >= 0.183333` | 21 | 13 | 22 | 71 | 5134.10 | 1746.40 | 74.6% | -513.40 | 519.3 |
| `option_strike_map_target_1_strike >= 7475` | 21 | 6 | 10 | 90 | 5756.90 | 1123.60 | 83.7% | -403.20 | 182.8 |
| `es_structure_pullback_from_high <= 3.25` | 21 | 8 | 27 | 71 | 5133.40 | 1747.10 | 74.6% | -403.20 | 178.4 |
| `es_structure_pullback_from_high <= 3.75` | 21 | 7 | 24 | 75 | 5277.90 | 1602.60 | 76.7% | -403.20 | 142.2 |
| `es_reclaim_samples <= 585` | 21 | 5 | 11 | 90 | 5822.00 | 1058.50 | 84.6% | -513.40 | 126.3 |
| `option_strike_map_target_1_strike >= 7500` | 21 | 7 | 26 | 73 | 5139.80 | 1740.70 | 74.7% | -403.20 | 114.3 |
| `es_structure_higher_low_distance >= -1` | 21 | 5 | 19 | 82 | 5504.40 | 1376.10 | 80.0% | -513.40 | 57.1 |
| `path_first_observed_seconds <= 9` | 21 | 5 | 24 | 77 | 5409.00 | 1471.50 | 78.6% | -513.40 | 32.5 |
| `es_structure_pullback_from_high <= 4` | 21 | 5 | 23 | 78 | 5395.70 | 1484.80 | 78.4% | -403.20 | 31.6 |

## Upside TP Extension Candidates
| all | No upside TP extension candidates found. |  |  |  |  |  |  |  |  |  |  |

## Event Counts
- blocked: 36166
- position_wait: 8113
- stale_es_vwap: 4867
- trade_risk_extend_signal: 1192
- trade_risk_tighten_signal: 521
- order_event: 477
- waiting_spx_quote: 414
- entry_signal: 106

## Blocked Gate Counts
- setup_quality_allowed: 14458 (disabled=14458)
- above_vwap_confirmed: 9088 (disabled=9088)
- above_vwap: 8079 (disabled=8079)
- es_structure_allowed: 7949 (disabled=7949)
- pullback: 6257 (disabled=6257)
- es_vwap_slope_allowed: 4459 (disabled=4459)
- momentum: 4341 (disabled=4341)
- es_vwap_max_distance_allowed: 4001 (disabled=4001)
- trend_strength: 3240 (disabled=3240)
- es_vwap_acceleration_allowed: 2514 (disabled=2514)
- es_rolling_high_allowed: 748 (disabled=748)
- indicator_slope_allowed: 241 (disabled=241)

## By UTC Hour

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 13 | 12 | 728.40 | 60.70 | 100.0% | 0.4 |
| 8 | 11 | 1304.70 | 118.61 | 100.0% | 16.6 |
| 14 | 10 | 472.70 | 47.27 | 100.0% | 1.5 |
| 12 | 8 | 353.30 | 44.16 | 100.0% | 12.1 |
| 15 | 7 | 452.10 | 64.59 | 100.0% | 6.5 |
| 1 | 6 | 515.30 | 85.88 | 100.0% | 3.0 |
| 18 | 6 | 337.60 | 56.27 | 100.0% | 10.4 |
| 11 | 5 | 178.20 | 35.64 | 100.0% | 12.0 |
| 5 | 5 | 245.10 | 49.02 | 100.0% | 20.6 |
| 6 | 5 | 243.10 | 48.62 | 100.0% | 16.4 |
| 9 | 5 | 290.80 | 58.16 | 100.0% | 12.0 |
| 19 | 4 | 235.40 | 58.85 | 100.0% | 12.7 |
| 2 | 4 | 214.50 | 53.63 | 100.0% | 48.6 |
| 22 | 4 | 392.90 | 98.23 | 100.0% | 14.9 |
| 7 | 4 | 241.70 | 60.42 | 100.0% | 12.0 |
| 0 | 3 | 174.40 | 58.13 | 100.0% | 12.1 |
| 10 | 2 | 160.80 | 80.40 | 100.0% | 13.0 |
| 23 | 2 | 70.00 | 35.00 | 100.0% | 29.5 |
| 3 | 2 | 150.50 | 75.25 | 100.0% | 15.9 |
| 17 | 1 | 119.00 | 119.00 | 100.0% | 7.3 |

## By RSI Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <55 | 57 | 3559.60 | 62.45 | 100.0% | 7.1 |
| 55-60 | 16 | 1302.00 | 81.38 | 100.0% | 14.7 |
| >=75 | 11 | 1012.60 | 92.05 | 100.0% | 9.9 |
| 70-75 | 9 | 448.00 | 49.78 | 100.0% | 20.0 |
| 60-65 | 8 | 395.50 | 49.44 | 100.0% | 27.6 |
| 65-70 | 5 | 162.80 | 32.56 | 100.0% | 16.4 |

## By ADX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <20 | 43 | 2954.00 | 68.70 | 100.0% | 8.8 |
| 20-25 | 21 | 1289.40 | 61.40 | 100.0% | 12.2 |
| 25-30 | 19 | 1192.10 | 62.74 | 100.0% | 12.0 |
| 30-40 | 18 | 1124.00 | 62.44 | 100.0% | 12.0 |
| 40-50 | 4 | 281.40 | 70.35 | 100.0% | 8.4 |
| >=50 | 1 | 39.60 | 39.60 | 100.0% | 17.0 |

## By VIX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| missing | 106 | 6880.50 | 64.91 | 100.0% | 12.0 |

## By ES VWAP Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.25 | 102 | 6678.20 | 65.47 | 100.0% | 12.0 |
| 0.25-0.5 | 3 | 185.30 | 61.77 | 100.0% | 5.8 |
| 0.5-1 | 1 | 17.00 | 17.00 | 100.0% | 29.9 |

## By ES VWAP Acceleration Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.05 | 49 | 3257.70 | 66.48 | 100.0% | 12.0 |
| -0.05-0 | 36 | 2326.60 | 64.63 | 100.0% | 7.8 |
| 0.1-0.25 | 10 | 658.50 | 65.85 | 100.0% | 15.7 |
| 0.05-0.1 | 6 | 287.40 | 47.90 | 100.0% | 20.5 |
| >=0.25 | 2 | 53.00 | 26.50 | 100.0% | 55.9 |
| -0.1--0.05 | 1 | 125.80 | 125.80 | 100.0% | 11.9 |
| -0.25--0.1 | 1 | 87.50 | 87.50 | 100.0% | 6.7 |
| <-0.25 | 1 | 84.00 | 84.00 | 100.0% | 2.4 |

## By ES Rolling High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-6 | 29 | 1498.70 | 51.68 | 100.0% | 5.8 |
| 2-4 | 23 | 1253.50 | 54.50 | 100.0% | 15.3 |
| 0-1 | 19 | 1605.10 | 84.48 | 100.0% | 13.2 |
| 6-8 | 13 | 1032.60 | 79.43 | 100.0% | 8.4 |
| 8-12 | 8 | 397.00 | 49.62 | 100.0% | 13.0 |
| 12-20 | 7 | 658.40 | 94.06 | 100.0% | 6.6 |
| 1-2 | 6 | 400.20 | 66.70 | 100.0% | 18.6 |
| >=20 | 1 | 35.00 | 35.00 | 100.0% | 19.1 |

## By ES Rolling High Minutes Since

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 20-30 | 35 | 2493.60 | 71.25 | 100.0% | 8.7 |
| <1 | 23 | 1793.80 | 77.99 | 100.0% | 14.7 |
| 1-3 | 13 | 566.40 | 43.57 | 100.0% | 17.3 |
| 5-10 | 13 | 833.30 | 64.10 | 100.0% | 8.8 |
| 10-20 | 12 | 645.80 | 53.82 | 100.0% | 12.3 |
| 3-5 | 9 | 481.10 | 53.46 | 100.0% | 8.4 |
| 30-60 | 1 | 66.50 | 66.50 | 100.0% | 12.0 |

## By RSI Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| >=3 | 33 | 2173.60 | 65.87 | 100.0% | 12.1 |
| 0-1 | 21 | 1107.30 | 52.73 | 100.0% | 5.5 |
| -1-0 | 9 | 612.30 | 68.03 | 100.0% | 12.0 |
| -3--2 | 8 | 323.80 | 40.48 | 100.0% | 6.8 |
| 1-2 | 8 | 613.80 | 76.73 | 100.0% | 13.5 |
| <-3 | 8 | 398.30 | 49.79 | 100.0% | 5.8 |
| -2--1 | 7 | 507.40 | 72.49 | 100.0% | 12.0 |
| 2-3 | 6 | 702.60 | 117.10 | 100.0% | 17.8 |
| missing | 6 | 441.40 | 73.57 | 100.0% | 8.4 |

## By ADX Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-1 | 39 | 2265.10 | 58.08 | 100.0% | 11.9 |
| -1-0 | 34 | 2638.80 | 77.61 | 100.0% | 12.3 |
| 1-2 | 19 | 1234.80 | 64.99 | 100.0% | 7.3 |
| -2--1 | 8 | 300.40 | 37.55 | 100.0% | 21.3 |
| missing | 6 | 441.40 | 73.57 | 100.0% | 8.4 |

## By ES Higher-Low Distance Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 2-4 | 33 | 1784.60 | 54.08 | 100.0% | 12.7 |
| 4-8 | 21 | 1892.00 | 90.10 | 100.0% | 12.0 |
| 1-2 | 20 | 1133.00 | 56.65 | 100.0% | 7.8 |
| >=8 | 16 | 1204.80 | 75.30 | 100.0% | 14.4 |
| 0-0.5 | 9 | 445.80 | 49.53 | 100.0% | 1.9 |
| 0.5-1 | 7 | 420.30 | 60.04 | 100.0% | 11.9 |

## By ES Structure Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4 | 38 | 2600.80 | 68.44 | 100.0% | 12.0 |
| 3 | 36 | 2377.40 | 66.04 | 100.0% | 12.0 |
| 5 | 31 | 1868.30 | 60.27 | 100.0% | 11.9 |
| 2 | 1 | 34.00 | 34.00 | 100.0% | 12.1 |

## By ES Structure Pullback From High

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-2 | 46 | 3653.20 | 79.42 | 100.0% | 12.6 |
| 2-4 | 29 | 1624.70 | 56.02 | 100.0% | 11.9 |
| 4-8 | 24 | 1169.30 | 48.72 | 100.0% | 6.0 |
| 8-12 | 5 | 223.50 | 44.70 | 100.0% | 17.3 |
| 12-16 | 1 | 84.00 | 84.00 | 100.0% | 2.4 |
| 16-24 | 1 | 125.80 | 125.80 | 100.0% | 11.9 |

## By ES Structure Higher-Low Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 39 | 2456.50 | 62.99 | 100.0% | 12.0 |
| 2-4 | 17 | 636.50 | 37.44 | 100.0% | 20.0 |
| 1-2 | 12 | 981.50 | 81.79 | 100.0% | 12.0 |
| 0.5-1 | 11 | 965.60 | 87.78 | 100.0% | 3.8 |
| 4-8 | 10 | 544.70 | 54.47 | 100.0% | 7.4 |
| >=8 | 9 | 717.50 | 79.72 | 100.0% | 12.0 |
| 0-0.5 | 8 | 578.20 | 72.28 | 100.0% | 10.8 |

## By ES Structure Higher-High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 38 | 2694.00 | 70.89 | 100.0% | 8.6 |
| 2-4 | 18 | 923.10 | 51.28 | 100.0% | 3.7 |
| 1-2 | 15 | 898.50 | 59.90 | 100.0% | 20.0 |
| 4-8 | 15 | 1114.10 | 74.27 | 100.0% | 12.0 |
| >=8 | 9 | 560.00 | 62.22 | 100.0% | 14.7 |
| 0-0.5 | 7 | 437.90 | 62.56 | 100.0% | 16.4 |
| 0.5-1 | 4 | 252.90 | 63.23 | 100.0% | 10.4 |

## By ES Structure VWAP Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 38 | 2671.90 | 70.31 | 100.0% | 13.9 |
| >=24 | 28 | 1011.50 | 36.13 | 100.0% | 2.7 |
| 8-12 | 15 | 1621.20 | 108.08 | 100.0% | 23.3 |
| 12-16 | 8 | 510.10 | 63.76 | 100.0% | 12.0 |
| 2-4 | 8 | 590.80 | 73.85 | 100.0% | 9.3 |
| 16-24 | 5 | 250.10 | 50.02 | 100.0% | 8.4 |
| 0-2 | 4 | 224.90 | 56.22 | 100.0% | 11.9 |

## By Setup Quality Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 50-60 | 35 | 2591.80 | 74.05 | 100.0% | 6.6 |
| 60-70 | 25 | 1377.50 | 55.10 | 100.0% | 12.0 |
| 70-80 | 18 | 1115.90 | 61.99 | 100.0% | 12.0 |
| 40-50 | 17 | 1244.20 | 73.19 | 100.0% | 12.7 |
| 80-90 | 11 | 551.10 | 50.10 | 100.0% | 16.6 |

## By Entry-Veto Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 1-2 | 23 | 1652.70 | 71.86 | 100.0% | 12.1 |
| 2-3 | 22 | 1051.20 | 47.78 | 100.0% | 13.8 |
| 3-4 | 22 | 1427.20 | 64.87 | 100.0% | 10.3 |
| 4-5 | 15 | 1125.80 | 75.05 | 100.0% | 5.5 |
| 5-6 | 15 | 878.30 | 58.55 | 100.0% | 7.2 |
| <1 | 9 | 745.30 | 82.81 | 100.0% | 12.0 |

## By Slow-Risk Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <1 | 106 | 6880.50 | 64.91 | 100.0% | 12.0 |

## By Entry Risk Tier

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| standard | 106 | 6880.50 | 64.91 | 100.0% | 12.0 |

## By ES Reclaim Current Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 38 | 2671.90 | 70.31 | 100.0% | 13.9 |
| >=24 | 28 | 1011.50 | 36.13 | 100.0% | 2.7 |
| 8-12 | 15 | 1621.20 | 108.08 | 100.0% | 23.3 |
| 12-16 | 8 | 510.10 | 63.76 | 100.0% | 12.0 |
| 2-4 | 8 | 590.80 | 73.85 | 100.0% | 9.3 |
| 16-24 | 5 | 250.10 | 50.02 | 100.0% | 8.4 |
| 0-2 | 4 | 224.90 | 56.22 | 100.0% | 11.9 |

## By SPX EMA20 Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 69 | 3947.30 | 57.21 | 100.0% | 8.4 |
| 2-4 | 13 | 1195.70 | 91.98 | 100.0% | 24.9 |
| 4-6 | 8 | 586.60 | 73.33 | 100.0% | 10.9 |
| 8-12 | 5 | 650.10 | 130.02 | 100.0% | 12.1 |
| 1-2 | 4 | 142.00 | 35.50 | 100.0% | 54.7 |
| >=12 | 4 | 197.80 | 49.45 | 100.0% | 20.0 |
| 6-8 | 2 | 70.00 | 35.00 | 100.0% | 40.7 |
| 0-1 | 1 | 91.00 | 91.00 | 100.0% | 12.0 |

## By Hold-Time Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 5-15 | 38 | 3150.10 | 82.90 | 100.0% | 11.9 |
| <5 | 29 | 2011.80 | 69.37 | 100.0% | 1.2 |
| 15-30 | 26 | 836.10 | 32.16 | 100.0% | 19.5 |
| 60-180 | 7 | 264.00 | 37.71 | 100.0% | 90.2 |
| 30-60 | 5 | 168.50 | 33.70 | 100.0% | 38.0 |
| 180-720 | 1 | 450.00 | 450.00 | 100.0% | 198.3 |

## By VIX Regime

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| disabled | 106 | 6880.50 | 64.91 | 100.0% | 12.0 |

## By Option Data State

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 80 | 5200.10 | 65.00 | 100.0% | 11.9 |
| VALID_1DTE_ONLY | 20 | 1310.20 | 65.51 | 100.0% | 14.1 |
| STALE_0DTE | 5 | 162.80 | 32.56 | 100.0% | 23.3 |
| EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 |

## By Active Profile Set

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 80 | 5200.10 | 65.00 | 100.0% | 11.9 |
| VALID_1DTE_ONLY | 20 | 1310.20 | 65.51 | 100.0% | 14.1 |
| STALE_0DTE | 5 | 162.80 | 32.56 | 100.0% | 23.3 |
| EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 |

## Monthly Summary

| Month | Trades | PnL | Avg PnL | Median Hold Min | Exposure Hours | PnL/Exposure Hour | Slow >=12h |
| --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| 2026-06 | 69 | 4124.80 | 59.78 | 9.9 | 16.0 | 257.17 | 0 |
| 2026-07 | 37 | 2755.70 | 74.48 | 13.2 | 19.0 | 144.97 | 0 |

## TP Target Distribution

| Target | Trades | PnL | Avg PnL | Median Hold Min |
| --- | ---: | ---: | ---: | ---: |
| 2.34 | 1 | 84.00 | 84.00 | 3.0 |
| 2.40 | 34 | 1325.10 | 38.97 | 3.8 |
| 2.49 | 1 | 45.50 | 45.50 | 20.6 |
| 2.57 | 1 | 93.60 | 93.60 | 5.3 |
| 2.63 | 1 | 39.60 | 39.60 | 12.0 |
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
| 12.00 | 3 | 532.60 | 177.53 | 16.6 |
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
