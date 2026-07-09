# SPX500 IB Trend Scalper Analysis

- Metrics file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_032/execution-metrics.csv`
- Backtest file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_032/launcher/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm.json`
- Completed paired trades: 105
- Entry signals: 105
- Approx open/unpaired entry signals: 0
- Position/order maintenance waits: 7876
- Total paired trade PnL: 7069.50
- Win rate: 100.0%
- Realized loss trades: 0
- Median hold: 12.0 minutes
- Average hold: 18.7 minutes

## Lean Runtime Statistics
- Equity: $107,069.50
- Net Profit: $7,069.50
- Return: 7.07 %
- Probabilistic Sharpe Ratio: 100.000%
- Volume: $45,504,660.70

## Risk And Efficiency
- Exposure hours: 32.8
- PnL per exposure hour: 215.49
- Calendar span days: 12.3
- PnL per calendar day: 574.35
- Trades per calendar day: 8.53
- Exposure share of calendar time: 11.1%
- Growth quality score: 11098.2
- VIX stale at entry: 0.0%
- ES stale rows: 9.4%
- Waiting ES VWAP rows: 0.0%
- Trade-health exit signals: 0
- Trade-health tighten signals: 0
- Slow trades held >= 12 hours: 0 (0.0%)
- Slow exposure hours: 0.0
- Slow PnL per exposure hour: 
- Fast <15m trades: 66
- Fast PnL per exposure hour: 764.77

## Pullback Broken Structure Veto
- Blocked signal rows: 1244
- Blocked by profile: `{"charm_pin_pullback_long": 1189, "pullback_long": 55}`
- Blocked net profit / worst MAE: not available for hard-blocked signals because they do not become completed trades.
- Remaining trades by profile: `{"breakout_long_1dte": 20, "breakout_long_no_0dte": 3, "charm_pin_pullback_long": 34, "charm_wall_breakaway_long": 5, "pullback_long": 30, "pullback_long_no_0dte": 3, "squeeze_long": 10}`
- Remaining PnL by profile: `{"breakout_long_1dte": 1311.1999999999916, "breakout_long_no_0dte": 278.40000000001237, "charm_pin_pullback_long": 1261.5000000001082, "charm_wall_breakaway_long": 986.5999999999876, "pullback_long": 2419.0000000001564, "pullback_long_no_0dte": 91.79999999999018, "squeeze_long": 721.0000000000064}`

## Lean Portfolio And Trade Statistics
- Portfolio: sharpeRatio=30.9166, sortinoRatio=0, alpha=0, beta=0, informationRatio=31.5035, drawdown=0.004
- Trades: sharpeRatio=1.0145, averageMAE=-97.4429, averageMFE=85.9710, largestMAE=-513.4, largestMFE=462.60, maximumIntraTradeDrawdown=-564.4

## Strategy Profile Performance

| Strategy | Enabled | Data State | Profile Set | Trades | PnL | Avg PnL | Win Rate | Median Hold Min | Exposure Hrs | PnL/Exposure Hr | Slow >=12h | Worst MAE | Median MFE | Median TP |
| --- | --- | --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| pullback_long | true | VALID_0DTE | VALID_0DTE | 30 | 2419.00 | 80.63 | 100.0% | 10.8 | 6.9 | 349.62 | 0 | -379.80 | 112.65 | 3.32 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 1311.20 | 65.56 | 100.0% | 14.1 | 7.7 | 169.57 | 0 | -375.70 | 79.88 | 3.00 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 34 | 1261.50 | 37.10 | 100.0% | 5.0 | 7.0 | 180.29 | 0 | -513.40 | 42.50 | 2.40 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 5 | 986.60 | 197.32 | 100.0% | 16.0 | 4.2 | 234.59 | 0 | -346.80 | 146.20 | 12.00 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 10 | 721.00 | 72.10 | 100.0% | 15.7 | 3.9 | 187.16 | 0 | -208.25 | 77.78 | 33.59 |
| breakout_long_no_0dte | true | EXPIRED_0DTE | EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 | 0.2 | 845.57 | 0 | -76.50 | 243.10 | 6.00 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 3 | 91.80 | 30.60 | 100.0% | 16.4 | 1.1 | 83.22 | 0 | -103.50 | 27.90 | 4.00 |
| breakout_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 2 | 71.00 | 35.50 | 100.0% | 52.6 | 1.8 | 40.51 | 0 | -250.25 | 62.27 | 6.00 |
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
| pullback_long | true | VALID_0DTE | VALID_0DTE | 30 | 50.21 | 6.44 | 47.87 | 21.20 | 13.8 | 0 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 66.60 | 5.94 | 70.56 | 26.99 | 23.2 | 0 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 34 | 66.83 | 29.56 | 49.67 | 19.65 | 12.3 | 0 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 5 | 75.96 | 21.06 | 57.99 | 17.35 | 50.5 | 0 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 10 | 69.16 | 11.21 | 69.11 | 21.34 | 23.1 | 0 |
| breakout_long_no_0dte | true | EXPIRED_0DTE | EXPIRED_0DTE | 1 | 70.88 | 7.38 | 81.57 | 27.17 | 14.7 | 0 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 3 | 54.55 | 5.48 | 48.15 | 19.52 | 22.1 | 0 |
| breakout_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 2 | 78.32 | 11.24 | 80.45 | 28.97 | 52.6 | 0 |
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
- MAE: average -98.38, median -65.05, worst -513.40
- MFE: average 85.97, median 59.50, best 462.60
- Average MFE / absolute MAE: 0.87

## Intratrade Path
- Trades with path stats: 105; with intratrade price samples: 105
- Went positive before max adverse: 54.3%
- MFE happened before MAE: 11.4%
- TP touched before MAE: 1.9%
- Median MFE available before MAE: 0.05 points
- Median first TP touch: 3.8 minutes
- Median first +1.5 points: 2.8 minutes
- First 15m MFE/MAE medians: 2.40 / -1.80 points

## Worst Tail Trade Autopsy
- Worst tail entry: `2026-06-26T12:36:24+00:00` -> `2026-06-26T13:56:26+00:00`.
- Strategy/profile: `charm_pin_pullback_long` / `charm_pin_pullback_long`. PnL 42.50, MAE -513.40, MFE 51.00, hold 80.0 minutes.
- Profile context: `charm_pin_pullback_long` produced 34 trades, PnL 1261.50, 0 slow >=12h trades, and 17.8% of total PnL.
- Entry state: setup=61.77, ES-VWAP=26.69, VWAP slope=0.0417, VWAP acceleration=-0.0179, RSI=42.42, ADX=17.95, structure score=4.00, higher-low=0.2500, higher-high=3.75, pullback-from-high=9.25, rolling-high distance=14.25.
- Guard state: setup allowed=`True`, entry veto allowed=`True`, veto points=4.00, slow-risk points=0.00.
- Existing warning reason: ES pullback from high 9.25 >= 5.00; RSI slope -3.8597 <= -2.0000; ADX 17.95 <= 18.00; RSI 42.42 <= 45.00.
- Strategy selection reason: positive gamma/charm pin pullback: expectedMovePosition=0.0105, netCharm30m=-25186308, lowerFade=False, pullback=True, dynamicMaxVwapDistance=17.89.
- Intratrade path: path MFE 2.50, path MAE -27.70, MFE before MAE=`False`, TP reached=`True`.
- Surgical setup floor check: `setup_quality_score >= 61.8` would block this trade, keep 51 trades, retain 45.3% PnL, and leave worst MAE -375.70. It would block 54 trades total.
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
| `es_structure_rising_vwap != "False"` | 20 | 7 | 13 | 85 | 5585.80 | 1483.70 | 79.0% | -513.40 | 12439.0 |
| `long_strategy != "breakout_long_1dte"` | 20 | 6 | 14 | 85 | 5758.30 | 1311.20 | 81.5% | -513.40 | 12399.2 |
| `strategy_profile != "breakout_long_1dte"` | 20 | 6 | 14 | 85 | 5758.30 | 1311.20 | 81.5% | -513.40 | 12399.2 |
| `path_half_tp_touch_minutes >= 0.183333` | 20 | 12 | 22 | 71 | 5415.10 | 1654.40 | 76.6% | -513.40 | 509.2 |
| `es_structure_higher_low_distance >= -1` | 20 | 5 | 17 | 83 | 5910.40 | 1159.10 | 83.6% | -513.40 | 115.9 |
| `es_reclaim_samples <= 585` | 20 | 5 | 11 | 89 | 5787.20 | 1282.30 | 81.9% | -513.40 | 102.7 |
| `path_first_observed_points <= 0.05` | 20 | 4 | 15 | 86 | 5943.70 | 1125.80 | 84.1% | -379.80 | 54.9 |
| `path_first_nonzero_move_points <= 0.05` | 20 | 4 | 16 | 85 | 5902.90 | 1166.60 | 83.5% | -379.80 | 46.0 |
| `es_reclaim_samples <= 590` | 20 | 4 | 10 | 91 | 5846.70 | 1222.80 | 82.7% | -513.40 | 44.9 |
| `es_structure_score <= 4` | 20 | 6 | 26 | 73 | 5082.00 | 1987.50 | 71.9% | -513.40 | 23.2 |
| `path_first_observed_seconds >= 2` | 20 | 4 | 18 | 83 | 5762.20 | 1307.30 | 81.5% | -513.40 | 17.7 |
| `path_first_nonzero_move_seconds >= 2` | 20 | 4 | 18 | 83 | 5762.20 | 1307.30 | 81.5% | -513.40 | 17.7 |

## Upside TP Extension Candidates
| all | No upside TP extension candidates found. |  |  |  |  |  |  |  |  |  |  |

## Event Counts
- blocked: 36403
- position_wait: 7876
- stale_es_vwap: 4867
- trade_risk_extend_signal: 1192
- trade_risk_tighten_signal: 536
- order_event: 473
- waiting_spx_quote: 414
- entry_signal: 105

## Blocked Gate Counts
- setup_quality_allowed: 14559 (disabled=14559)
- above_vwap_confirmed: 9102 (disabled=9102)
- above_vwap: 8096 (disabled=8096)
- es_structure_allowed: 7851 (disabled=7851)
- pullback: 6667 (disabled=6667)
- momentum: 4245 (disabled=4245)
- es_vwap_max_distance_allowed: 3896 (disabled=3896)
- es_vwap_slope_allowed: 3744 (disabled=3744)
- trend_strength: 3371 (disabled=3371)
- es_vwap_acceleration_allowed: 1941 (disabled=1941)
- es_rolling_high_allowed: 519 (disabled=519)
- indicator_slope_allowed: 170 (disabled=170)

## By UTC Hour

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 13 | 12 | 735.60 | 61.30 | 100.0% | 0.4 |
| 8 | 11 | 1304.70 | 118.61 | 100.0% | 16.6 |
| 14 | 10 | 855.40 | 85.54 | 100.0% | 2.1 |
| 12 | 7 | 262.30 | 37.47 | 100.0% | 12.2 |
| 18 | 7 | 418.10 | 59.73 | 100.0% | 12.0 |
| 1 | 6 | 515.30 | 85.88 | 100.0% | 3.0 |
| 15 | 6 | 368.10 | 61.35 | 100.0% | 9.2 |
| 6 | 6 | 355.30 | 59.22 | 100.0% | 14.2 |
| 9 | 6 | 324.80 | 54.13 | 100.0% | 14.0 |
| 11 | 5 | 178.20 | 35.64 | 100.0% | 12.0 |
| 19 | 4 | 240.20 | 60.05 | 100.0% | 5.7 |
| 2 | 4 | 214.50 | 53.63 | 100.0% | 48.6 |
| 22 | 4 | 393.90 | 98.48 | 100.0% | 14.9 |
| 5 | 4 | 211.10 | 52.78 | 100.0% | 22.1 |
| 7 | 4 | 241.70 | 60.42 | 100.0% | 12.0 |
| 0 | 3 | 174.40 | 58.13 | 100.0% | 12.1 |
| 10 | 2 | 55.40 | 27.70 | 100.0% | 18.4 |
| 23 | 2 | 70.00 | 35.00 | 100.0% | 29.5 |
| 3 | 2 | 150.50 | 75.25 | 100.0% | 15.9 |

## By RSI Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <55 | 56 | 3394.10 | 60.61 | 100.0% | 7.1 |
| 55-60 | 16 | 1276.30 | 79.77 | 100.0% | 15.0 |
| >=75 | 11 | 1012.60 | 92.05 | 100.0% | 9.9 |
| 70-75 | 9 | 448.00 | 49.78 | 100.0% | 20.0 |
| 60-65 | 8 | 395.50 | 49.44 | 100.0% | 27.6 |
| 65-70 | 5 | 543.00 | 108.60 | 100.0% | 16.4 |

## By ADX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <20 | 42 | 2912.60 | 69.35 | 100.0% | 7.8 |
| 20-25 | 21 | 1672.10 | 79.62 | 100.0% | 12.2 |
| 30-40 | 19 | 1119.30 | 58.91 | 100.0% | 12.0 |
| 25-30 | 18 | 1115.10 | 61.95 | 100.0% | 12.1 |
| 40-50 | 4 | 210.80 | 52.70 | 100.0% | 13.8 |
| >=50 | 1 | 39.60 | 39.60 | 100.0% | 17.0 |

## By VIX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| missing | 105 | 7069.50 | 67.33 | 100.0% | 12.0 |

## By ES VWAP Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.25 | 101 | 6488.00 | 64.24 | 100.0% | 12.0 |
| 0.25-0.5 | 3 | 564.50 | 188.17 | 100.0% | 9.4 |
| 0.5-1 | 1 | 17.00 | 17.00 | 100.0% | 29.9 |

## By ES VWAP Acceleration Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.05 | 48 | 3175.60 | 66.16 | 100.0% | 12.0 |
| -0.05-0 | 38 | 2427.30 | 63.88 | 100.0% | 7.8 |
| 0.1-0.25 | 10 | 1038.70 | 103.87 | 100.0% | 15.7 |
| 0.05-0.1 | 6 | 287.40 | 47.90 | 100.0% | 20.5 |
| >=0.25 | 2 | 53.00 | 26.50 | 100.0% | 55.9 |
| -0.25--0.1 | 1 | 87.50 | 87.50 | 100.0% | 6.7 |

## By ES Rolling High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-6 | 28 | 1442.90 | 51.53 | 100.0% | 4.4 |
| 2-4 | 24 | 1405.20 | 58.55 | 100.0% | 12.0 |
| 0-1 | 20 | 1640.10 | 82.01 | 100.0% | 13.9 |
| 6-8 | 14 | 1386.70 | 99.05 | 100.0% | 12.0 |
| 1-2 | 6 | 400.20 | 66.70 | 100.0% | 18.6 |
| 12-20 | 6 | 489.40 | 81.57 | 100.0% | 5.2 |
| 8-12 | 6 | 270.00 | 45.00 | 100.0% | 13.0 |
| >=20 | 1 | 35.00 | 35.00 | 100.0% | 19.1 |

## By ES Rolling High Minutes Since

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 20-30 | 36 | 2551.10 | 70.86 | 100.0% | 8.0 |
| <1 | 24 | 1828.80 | 76.20 | 100.0% | 14.9 |
| 1-3 | 13 | 945.60 | 72.74 | 100.0% | 17.3 |
| 10-20 | 11 | 619.00 | 56.27 | 100.0% | 12.0 |
| 5-10 | 11 | 623.50 | 56.68 | 100.0% | 8.8 |
| 3-5 | 10 | 501.50 | 50.15 | 100.0% | 10.2 |

## By RSI Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| >=3 | 30 | 2325.10 | 77.50 | 100.0% | 12.0 |
| 0-1 | 21 | 1057.30 | 50.35 | 100.0% | 6.6 |
| <-3 | 10 | 530.90 | 53.09 | 100.0% | 6.9 |
| -1-0 | 9 | 612.30 | 68.03 | 100.0% | 12.0 |
| -3--2 | 8 | 323.80 | 40.48 | 100.0% | 6.8 |
| -2--1 | 7 | 514.60 | 73.51 | 100.0% | 12.0 |
| 1-2 | 7 | 488.00 | 69.71 | 100.0% | 15.0 |
| missing | 7 | 514.90 | 73.56 | 100.0% | 8.5 |
| 2-3 | 6 | 702.60 | 117.10 | 100.0% | 17.8 |

## By ADX Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-1 | 40 | 2672.30 | 66.81 | 100.0% | 12.0 |
| -1-0 | 33 | 2502.10 | 75.82 | 100.0% | 12.7 |
| 1-2 | 18 | 1115.80 | 61.99 | 100.0% | 7.1 |
| -2--1 | 7 | 264.40 | 37.77 | 100.0% | 16.5 |
| missing | 7 | 514.90 | 73.56 | 100.0% | 8.5 |

## By ES Higher-Low Distance Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 2-4 | 32 | 1787.10 | 55.85 | 100.0% | 10.4 |
| 1-2 | 20 | 1098.10 | 54.91 | 100.0% | 9.0 |
| 4-8 | 20 | 2181.20 | 109.06 | 100.0% | 10.9 |
| >=8 | 16 | 1113.00 | 69.56 | 100.0% | 15.3 |
| 0-0.5 | 10 | 469.80 | 46.98 | 100.0% | 4.5 |
| 0.5-1 | 7 | 420.30 | 60.04 | 100.0% | 11.9 |

## By ES Structure Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4 | 40 | 2573.80 | 64.35 | 100.0% | 12.0 |
| 3 | 32 | 2474.20 | 77.32 | 100.0% | 12.0 |
| 5 | 32 | 1987.50 | 62.11 | 100.0% | 10.3 |
| 2 | 1 | 34.00 | 34.00 | 100.0% | 12.1 |

## By ES Structure Pullback From High

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-2 | 46 | 3612.50 | 78.53 | 100.0% | 12.6 |
| 2-4 | 29 | 1664.60 | 57.40 | 100.0% | 11.9 |
| 4-8 | 25 | 1568.90 | 62.76 | 100.0% | 8.4 |
| 8-12 | 5 | 223.50 | 44.70 | 100.0% | 17.3 |

## By ES Structure Higher-Low Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 36 | 2587.30 | 71.87 | 100.0% | 12.0 |
| 2-4 | 17 | 636.50 | 37.44 | 100.0% | 20.0 |
| 0.5-1 | 12 | 1081.40 | 90.12 | 100.0% | 4.8 |
| 1-2 | 12 | 896.50 | 74.71 | 100.0% | 11.9 |
| 4-8 | 11 | 565.10 | 51.37 | 100.0% | 9.9 |
| >=8 | 9 | 717.50 | 79.72 | 100.0% | 12.0 |
| 0-0.5 | 8 | 585.20 | 73.15 | 100.0% | 10.8 |

## By ES Structure Higher-High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 36 | 2539.00 | 70.53 | 100.0% | 7.9 |
| 2-4 | 19 | 1337.30 | 70.38 | 100.0% | 9.4 |
| 1-2 | 16 | 1017.70 | 63.61 | 100.0% | 16.0 |
| 4-8 | 16 | 1134.50 | 70.91 | 100.0% | 12.1 |
| >=8 | 9 | 560.00 | 62.22 | 100.0% | 14.7 |
| 0-0.5 | 5 | 228.10 | 45.62 | 100.0% | 17.4 |
| 0.5-1 | 4 | 252.90 | 63.23 | 100.0% | 10.4 |

## By ES Structure VWAP Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 37 | 2679.10 | 72.41 | 100.0% | 12.7 |
| >=24 | 29 | 1031.90 | 35.58 | 100.0% | 2.8 |
| 8-12 | 14 | 1502.60 | 107.33 | 100.0% | 23.5 |
| 2-4 | 8 | 591.80 | 73.97 | 100.0% | 9.3 |
| 12-16 | 7 | 426.10 | 60.87 | 100.0% | 12.0 |
| 16-24 | 6 | 613.10 | 102.18 | 100.0% | 8.9 |
| 0-2 | 4 | 224.90 | 56.22 | 100.0% | 11.9 |

## By Setup Quality Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 50-60 | 34 | 2460.00 | 72.35 | 100.0% | 7.5 |
| 60-70 | 24 | 1311.00 | 54.63 | 100.0% | 12.0 |
| 70-80 | 20 | 1499.30 | 74.97 | 100.0% | 12.0 |
| 40-50 | 16 | 1248.10 | 78.01 | 100.0% | 11.9 |
| 80-90 | 11 | 551.10 | 50.10 | 100.0% | 16.6 |

## By Entry-Veto Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 1-2 | 24 | 1693.50 | 70.56 | 100.0% | 12.1 |
| 2-3 | 22 | 960.40 | 43.65 | 100.0% | 15.8 |
| 3-4 | 22 | 1363.70 | 61.99 | 100.0% | 10.3 |
| 4-5 | 15 | 1583.20 | 105.55 | 100.0% | 7.1 |
| 5-6 | 13 | 716.40 | 55.11 | 100.0% | 7.2 |
| <1 | 9 | 752.30 | 83.59 | 100.0% | 12.0 |

## By Slow-Risk Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <1 | 105 | 7069.50 | 67.33 | 100.0% | 12.0 |

## By Entry Risk Tier

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| standard | 105 | 7069.50 | 67.33 | 100.0% | 12.0 |

## By ES Reclaim Current Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 37 | 2679.10 | 72.41 | 100.0% | 12.7 |
| >=24 | 29 | 1031.90 | 35.58 | 100.0% | 2.8 |
| 8-12 | 14 | 1502.60 | 107.33 | 100.0% | 23.5 |
| 2-4 | 8 | 591.80 | 73.97 | 100.0% | 9.3 |
| 12-16 | 7 | 426.10 | 60.87 | 100.0% | 12.0 |
| 16-24 | 6 | 613.10 | 102.18 | 100.0% | 8.9 |
| 0-2 | 4 | 224.90 | 56.22 | 100.0% | 11.9 |

## By SPX EMA20 Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 68 | 4192.30 | 61.65 | 100.0% | 8.5 |
| 2-4 | 13 | 1196.70 | 92.05 | 100.0% | 24.9 |
| 4-6 | 8 | 586.60 | 73.33 | 100.0% | 10.9 |
| 8-12 | 5 | 650.10 | 130.02 | 100.0% | 12.1 |
| >=12 | 5 | 231.80 | 46.36 | 100.0% | 16.6 |
| 1-2 | 4 | 142.00 | 35.50 | 100.0% | 54.7 |
| 6-8 | 2 | 70.00 | 35.00 | 100.0% | 40.7 |

## By Hold-Time Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 5-15 | 38 | 3434.10 | 90.37 | 100.0% | 10.9 |
| <5 | 28 | 1931.40 | 68.98 | 100.0% | 1.4 |
| 15-30 | 27 | 857.50 | 31.76 | 100.0% | 20.0 |
| 60-180 | 6 | 228.00 | 38.00 | 100.0% | 86.0 |
| 30-60 | 5 | 168.50 | 33.70 | 100.0% | 38.0 |
| 180-720 | 1 | 450.00 | 450.00 | 100.0% | 198.3 |

## By VIX Regime

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| disabled | 105 | 7069.50 | 67.33 | 100.0% | 12.0 |

## By Option Data State

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 79 | 5388.10 | 68.20 | 100.0% | 11.9 |
| VALID_1DTE_ONLY | 20 | 1311.20 | 65.56 | 100.0% | 14.1 |
| STALE_0DTE | 5 | 162.80 | 32.56 | 100.0% | 23.3 |
| EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 |

## By Active Profile Set

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 79 | 5388.10 | 68.20 | 100.0% | 11.9 |
| VALID_1DTE_ONLY | 20 | 1311.20 | 65.56 | 100.0% | 14.1 |
| STALE_0DTE | 5 | 162.80 | 32.56 | 100.0% | 23.3 |
| EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 |

## Monthly Summary

| Month | Trades | PnL | Avg PnL | Median Hold Min | Exposure Hours | PnL/Exposure Hour | Slow >=12h |
| --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| 2026-06 | 69 | 4408.70 | 63.89 | 9.9 | 16.2 | 272.00 | 0 |
| 2026-07 | 36 | 2660.80 | 73.91 | 14.3 | 16.6 | 160.30 | 0 |

## TP Target Distribution

| Target | Trades | PnL | Avg PnL | Median Hold Min |
| --- | ---: | ---: | ---: | ---: |
| 2.34 | 1 | 84.00 | 84.00 | 3.0 |
| 2.40 | 34 | 1261.50 | 37.10 | 5.0 |
| 2.49 | 1 | 45.50 | 45.50 | 20.6 |
| 2.57 | 1 | 93.60 | 93.60 | 5.3 |
| 2.63 | 1 | 39.60 | 39.60 | 12.0 |
| 2.92 | 1 | 112.20 | 112.20 | 7.1 |
| 2.99 | 1 | 105.00 | 105.00 | 8.5 |
| 3.00 | 20 | 1311.20 | 65.56 | 14.1 |
| 3.02 | 2 | 147.60 | 73.80 | 49.9 |
| 3.09 | 1 | 55.80 | 55.80 | 11.9 |
| 3.13 | 1 | 59.50 | 59.50 | 12.0 |
| 3.14 | 1 | 108.50 | 108.50 | 6.5 |
| 3.19 | 1 | 35.00 | 35.00 | 26.0 |
| 3.22 | 1 | 118.80 | 118.80 | 6.6 |
| 3.26 | 1 | 118.80 | 118.80 | 3.8 |
| 3.30 | 1 | 118.80 | 118.80 | 0.1 |
| 3.31 | 1 | 35.00 | 35.00 | 19.1 |
| 3.33 | 1 | 36.00 | 36.00 | 29.9 |
| 3.35 | 1 | 119.00 | 119.00 | 8.4 |
| 3.36 | 1 | 73.50 | 73.50 | 12.0 |
| 3.43 | 1 | 46.80 | 46.80 | 12.7 |
| 3.46 | 1 | 136.50 | 136.50 | 8.8 |
| 3.48 | 1 | 126.00 | 126.00 | 5.8 |
| 3.51 | 1 | 35.00 | 35.00 | 17.4 |
| 3.52 | 1 | 73.50 | 73.50 | 12.0 |
| 3.56 | 1 | 36.00 | 36.00 | 15.6 |
| 3.58 | 1 | 36.00 | 36.00 | 23.6 |
| 3.60 | 5 | 478.80 | 95.76 | 7.1 |
| 4.00 | 2 | 36.00 | 18.00 | 27.2 |
| 6.00 | 3 | 278.40 | 92.80 | 23.3 |
| 12.00 | 5 | 986.60 | 197.32 | 16.0 |
| 14.06 | 1 | 34.00 | 34.00 | 12.1 |
| 15.00 | 1 | 45.50 | 45.50 | 44.6 |
| 16.25 | 1 | 35.00 | 35.00 | 23.6 |
| 23.75 | 1 | 35.00 | 35.00 | 57.7 |
| 28.44 | 1 | 112.20 | 112.20 | 12.0 |
| 38.75 | 2 | 125.80 | 62.90 | 14.7 |
| 48.62 | 2 | 71.00 | 35.50 | 19.9 |
| 55.78 | 1 | 262.50 | 262.50 | 12.0 |

## Slow Trade Fingerprint
- Trades held >= 12 hours: 0 (0.0%)

## Interpretation Notes
- This strategy exits with take-profit orders only, so a high win rate can hide capital being tied up for a long time.
- The best setting candidates are usually found by reducing slow-to-profit entries, not simply maximizing raw entry count.
- Focus first on buckets with low average PnL or long median hold time, then test stricter RSI/ADX/VWAP/VIX filters against those buckets.
