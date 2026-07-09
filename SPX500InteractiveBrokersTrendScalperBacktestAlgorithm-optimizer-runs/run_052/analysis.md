# SPX500 IB Trend Scalper Analysis

- Metrics file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_052/execution-metrics.csv`
- Backtest file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_052/launcher/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm.json`
- Completed paired trades: 108
- Entry signals: 108
- Approx open/unpaired entry signals: 0
- Position/order maintenance waits: 7904
- Total paired trade PnL: 7369.60
- Win rate: 100.0%
- Realized loss trades: 0
- Median hold: 12.0 minutes
- Average hold: 19.0 minutes

## Lean Runtime Statistics
- Equity: $107,369.60
- Net Profit: $7,369.60
- Return: 7.37 %
- Probabilistic Sharpe Ratio: 100.000%
- Volume: $48,082,844.80

## Risk And Efficiency
- Exposure hours: 34.2
- PnL per exposure hour: 215.68
- Calendar span days: 12.3
- PnL per calendar day: 598.30
- Trades per calendar day: 8.77
- Exposure share of calendar time: 11.6%
- Growth quality score: 11270.3
- VIX stale at entry: 0.0%
- ES stale rows: 9.5%
- Waiting ES VWAP rows: 0.0%
- Trade-health exit signals: 0
- Trade-health tighten signals: 0
- Slow trades held >= 12 hours: 0 (0.0%)
- Slow exposure hours: 0.0
- Slow PnL per exposure hour: 
- Fast <15m trades: 67
- Fast PnL per exposure hour: 753.68

## Pullback Broken Structure Veto
- Blocked signal rows: 1331
- Blocked by profile: `{"charm_pin_pullback_long": 1279, "pullback_long": 52}`
- Blocked net profit / worst MAE: not available for hard-blocked signals because they do not become completed trades.
- Remaining trades by profile: `{"breakout_long_1dte": 20, "breakout_long_no_0dte": 3, "call_wall_acceptance_long": 2, "charm_pin_pullback_long": 32, "charm_wall_breakaway_long": 6, "pullback_long": 32, "pullback_long_no_0dte": 3, "squeeze_long": 10}`
- Remaining PnL by profile: `{"breakout_long_1dte": 1315.299999999992, "breakout_long_no_0dte": 278.40000000001237, "call_wall_acceptance_long": 640.5, "charm_pin_pullback_long": 1271.8000000001302, "charm_wall_breakaway_long": 593.4000000000069, "pullback_long": 2455.4000000001934, "pullback_long_no_0dte": 91.79999999999018, "squeeze_long": 723.0000000000064}`

## Lean Portfolio And Trade Statistics
- Portfolio: sharpeRatio=35.7373, sortinoRatio=0, alpha=0, beta=0, informationRatio=36.3507, drawdown=0.007
- Trades: sharpeRatio=1.0378, averageMAE=-102.9356, averageMFE=87.5093, largestMAE=-655.2, largestMFE=592.8, maximumIntraTradeDrawdown=-1248.0

## Strategy Profile Performance

| Strategy | Enabled | Data State | Profile Set | Trades | PnL | Avg PnL | Win Rate | Median Hold Min | Exposure Hrs | PnL/Exposure Hr | Slow >=12h | Worst MAE | Median MFE | Median TP |
| --- | --- | --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| pullback_long | true | VALID_0DTE | VALID_0DTE | 32 | 2455.40 | 76.73 | 100.0% | 12.0 | 10.5 | 233.84 | 0 | -403.20 | 98.50 | 3.32 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 1315.30 | 65.76 | 100.0% | 14.1 | 7.7 | 170.09 | 0 | -386.75 | 79.88 | 3.00 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 32 | 1271.80 | 39.74 | 100.0% | 4.2 | 5.6 | 228.73 | 0 | -335.75 | 42.50 | 2.40 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 10 | 723.00 | 72.30 | 100.0% | 15.7 | 3.9 | 187.68 | 0 | -214.20 | 77.78 | 33.59 |
| call_wall_acceptance_long | true | VALID_0DTE | VALID_0DTE | 2 | 640.50 | 320.25 | 100.0% | 66.2 | 2.2 | 290.29 | 0 | -655.20 | 364.57 | 24.81 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 6 | 593.40 | 98.90 | 100.0% | 13.9 | 1.2 | 487.84 | 0 | -357.00 | 106.75 | 6.00 |
| breakout_long_no_0dte | true | EXPIRED_0DTE | EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 | 0.2 | 845.57 | 0 | -76.50 | 243.10 | 6.00 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 3 | 91.80 | 30.60 | 100.0% | 16.4 | 1.1 | 83.22 | 0 | -103.50 | 27.90 | 4.00 |
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
| pullback_long | true | VALID_0DTE | VALID_0DTE | 32 | 50.07 | 6.44 | 48.61 | 21.20 | 19.7 | 0 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 66.60 | 5.83 | 70.56 | 26.99 | 23.2 | 0 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 32 | 66.14 | 29.56 | 47.61 | 20.76 | 10.4 | 0 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 10 | 69.16 | 11.21 | 69.11 | 21.34 | 23.1 | 0 |
| call_wall_acceptance_long | true | VALID_0DTE | VALID_0DTE | 2 | 72.97 | 22.88 | 54.16 | 28.60 | 66.2 | 0 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 6 | 75.99 | 18.22 | 63.86 | 17.05 | 12.2 | 0 |
| breakout_long_no_0dte | true | EXPIRED_0DTE | EXPIRED_0DTE | 1 | 70.88 | 7.38 | 81.57 | 27.17 | 14.7 | 0 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 3 | 54.55 | 5.48 | 48.15 | 19.52 | 22.1 | 0 |
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
- MAE: average -103.90, median -70.20, worst -655.20
- MFE: average 87.51, median 64.65, best 592.80
- Average MFE / absolute MAE: 0.84

## Intratrade Path
- Trades with path stats: 108; with intratrade price samples: 108
- Went positive before max adverse: 51.9%
- MFE happened before MAE: 11.1%
- TP touched before MAE: 0.9%
- Median MFE available before MAE: 0.05 points
- Median first TP touch: 2.8 minutes
- Median first +1.5 points: 2.6 minutes
- First 15m MFE/MAE medians: 2.40 / -2.00 points

## Worst Tail Trade Autopsy
- Worst tail entry: `2026-06-26T11:59:48+00:00` -> `2026-06-26T14:00:11+00:00`.
- Strategy/profile: `call_wall_acceptance_long` / `call_wall_acceptance_long`. PnL 546.00, MAE -655.20, MFE 592.80, hold 120.4 minutes.
- Profile context: `call_wall_acceptance_long` produced 2 trades, PnL 640.50, 0 slow >=12h trades, and 8.7% of total PnL.
- Entry state: setup=73.44, ES-VWAP=28.76, VWAP slope=0.0302, VWAP acceleration=-0.0176, RSI=54.73, ADX=14.45, structure score=5.00, higher-low=4.25, higher-high=3.00, pullback-from-high=4.50, rolling-high distance=4.50.
- Guard state: setup allowed=`True`, entry veto allowed=`True`, veto points=2.00, slow-risk points=0.00.
- Existing warning reason: RSI slope -2.5746 <= -2.0000; ADX 14.45 <= 18.00.
- Strategy selection reason: positive gamma call-wall acceptance: callPutVolumeImbalance=0.8914, callWall=7400.00, target=7458.20, distance=14.50, forwardDexRatio30m=0.6066.
- Intratrade path: path MFE 21.00, path MAE -22.70, MFE before MAE=`False`, TP reached=`True`.
- Surgical setup floor check: `setup_quality_score >= 73.5` would block this trade, keep 22 trades, retain 17.3% PnL, and leave worst MAE -386.75. It would block 86 trades total.
- No single candidate threshold in the report cleanly removes this tail; the closest visible guard is setup quality 73.44.

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
| `es_structure_rising_vwap != "False"` | 21 | 7 | 13 | 88 | 5883.50 | 1486.10 | 79.8% | -655.20 | 15820.0 |
| `long_strategy != "breakout_long_1dte"` | 21 | 6 | 14 | 88 | 6054.30 | 1315.30 | 82.2% | -655.20 | 15783.3 |
| `strategy_profile != "breakout_long_1dte"` | 21 | 6 | 14 | 88 | 6054.30 | 1315.30 | 82.2% | -655.20 | 15783.3 |
| `path_half_tp_touch_minutes >= 0.183333` | 21 | 11 | 25 | 72 | 5583.50 | 1786.10 | 75.8% | -655.20 | 374.3 |
| `option_strike_map_target_1_strike >= 7475` | 21 | 6 | 8 | 94 | 5797.50 | 1572.10 | 78.7% | -403.20 | 105.0 |
| `es_reclaim_samples <= 558` | 21 | 6 | 18 | 84 | 5847.70 | 1521.90 | 79.3% | -655.20 | 99.1 |
| `es_reclaim_samples <= 590` | 21 | 5 | 13 | 90 | 6123.80 | 1245.80 | 83.1% | -655.20 | 89.6 |
| `option_strike_map_target_2_strike <= 7599.55` | 21 | 6 | 20 | 82 | 5744.80 | 1624.80 | 78.0% | -655.20 | 77.5 |
| `path_first_observed_seconds >= 2` | 21 | 5 | 18 | 85 | 6090.00 | 1279.60 | 82.6% | -655.20 | 76.0 |
| `path_first_nonzero_move_seconds >= 2` | 21 | 5 | 18 | 85 | 6090.00 | 1279.60 | 82.6% | -655.20 | 76.0 |
| `option_strike_map_target_1_strike >= 7500` | 21 | 7 | 23 | 78 | 5222.90 | 2146.70 | 70.9% | -403.20 | 45.8 |
| `es_structure_pullback_from_high <= 3.75` | 21 | 7 | 23 | 78 | 5186.30 | 2183.30 | 70.4% | -403.20 | 39.2 |

## Upside TP Extension Candidates
| all | No upside TP extension candidates found. |  |  |  |  |  |  |  |  |  |  |

## Event Counts
- blocked: 36375
- position_wait: 7904
- stale_es_vwap: 4867
- trade_risk_tighten_signal: 592
- order_event: 488
- waiting_spx_quote: 415
- trade_risk_extend_signal: 312
- entry_signal: 108

## Blocked Gate Counts
- setup_quality_allowed: 14710 (disabled=14710)
- above_vwap_confirmed: 9377 (disabled=9377)
- above_vwap: 8365 (disabled=8365)
- es_structure_allowed: 8163 (disabled=8163)
- pullback: 6717 (disabled=6717)
- momentum: 4336 (disabled=4336)
- es_vwap_max_distance_allowed: 3946 (disabled=3946)
- es_vwap_slope_allowed: 3689 (disabled=3689)
- trend_strength: 3418 (disabled=3418)
- es_vwap_acceleration_allowed: 1942 (disabled=1942)
- es_rolling_high_allowed: 504 (disabled=504)
- indicator_slope_allowed: 156 (disabled=156)

## By UTC Hour

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 13 | 12 | 735.60 | 61.30 | 100.0% | 0.4 |
| 8 | 12 | 1124.50 | 93.71 | 100.0% | 13.9 |
| 14 | 10 | 646.80 | 64.68 | 100.0% | 2.1 |
| 9 | 9 | 472.40 | 52.49 | 100.0% | 12.0 |
| 15 | 7 | 452.10 | 64.59 | 100.0% | 6.5 |
| 1 | 6 | 515.30 | 85.88 | 100.0% | 3.0 |
| 11 | 5 | 707.20 | 141.44 | 100.0% | 12.0 |
| 12 | 5 | 229.30 | 45.86 | 100.0% | 12.2 |
| 18 | 5 | 296.80 | 59.36 | 100.0% | 12.0 |
| 19 | 5 | 276.20 | 55.24 | 100.0% | 8.4 |
| 5 | 5 | 245.10 | 49.02 | 100.0% | 20.6 |
| 6 | 5 | 243.10 | 48.62 | 100.0% | 16.4 |
| 2 | 4 | 214.50 | 53.63 | 100.0% | 48.6 |
| 22 | 4 | 393.90 | 98.48 | 100.0% | 14.9 |
| 7 | 4 | 243.40 | 60.85 | 100.0% | 12.0 |
| 0 | 3 | 178.50 | 59.50 | 100.0% | 12.1 |
| 10 | 2 | 55.40 | 27.70 | 100.0% | 18.4 |
| 23 | 2 | 70.00 | 35.00 | 100.0% | 29.5 |
| 3 | 2 | 150.50 | 75.25 | 100.0% | 15.9 |
| 17 | 1 | 119.00 | 119.00 | 100.0% | 7.3 |

## By RSI Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <55 | 58 | 4038.60 | 69.63 | 100.0% | 7.8 |
| 55-60 | 17 | 1132.50 | 66.62 | 100.0% | 12.0 |
| >=75 | 11 | 1016.70 | 92.43 | 100.0% | 9.9 |
| 70-75 | 10 | 495.80 | 49.58 | 100.0% | 18.7 |
| 60-65 | 7 | 353.00 | 50.43 | 100.0% | 29.4 |
| 65-70 | 5 | 333.00 | 66.60 | 100.0% | 16.4 |

## By ADX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <20 | 43 | 3226.30 | 75.03 | 100.0% | 9.7 |
| 20-25 | 22 | 1484.70 | 67.49 | 100.0% | 12.1 |
| 25-30 | 19 | 1186.60 | 62.45 | 100.0% | 12.1 |
| 30-40 | 19 | 1166.50 | 61.39 | 100.0% | 12.0 |
| 40-50 | 4 | 265.90 | 66.48 | 100.0% | 17.4 |
| >=50 | 1 | 39.60 | 39.60 | 100.0% | 17.0 |

## By VIX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| missing | 108 | 7369.60 | 68.24 | 100.0% | 12.0 |

## By ES VWAP Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.25 | 102 | 6915.30 | 67.80 | 100.0% | 12.0 |
| 0.25-0.5 | 4 | 401.30 | 100.33 | 100.0% | 10.8 |
| -0.25-0 | 1 | 36.00 | 36.00 | 100.0% | 56.0 |
| 0.5-1 | 1 | 17.00 | 17.00 | 100.0% | 29.9 |

## By ES VWAP Acceleration Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.05 | 51 | 3081.70 | 60.43 | 100.0% | 12.0 |
| -0.05-0 | 35 | 2806.40 | 80.18 | 100.0% | 8.4 |
| 0.1-0.25 | 10 | 828.70 | 82.87 | 100.0% | 15.7 |
| 0.05-0.1 | 6 | 291.50 | 48.58 | 100.0% | 20.5 |
| >=0.25 | 3 | 99.80 | 33.27 | 100.0% | 29.9 |
| -0.1--0.05 | 1 | 90.00 | 90.00 | 100.0% | 9.7 |
| -0.25--0.1 | 1 | 87.50 | 87.50 | 100.0% | 6.7 |
| <-0.25 | 1 | 84.00 | 84.00 | 100.0% | 2.4 |

## By ES Rolling High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-6 | 29 | 2044.90 | 70.51 | 100.0% | 5.8 |
| 2-4 | 22 | 1212.70 | 55.12 | 100.0% | 15.4 |
| 0-1 | 21 | 1691.00 | 80.52 | 100.0% | 14.7 |
| 6-8 | 13 | 949.30 | 73.02 | 100.0% | 10.3 |
| 8-12 | 8 | 379.60 | 47.45 | 100.0% | 13.0 |
| 12-20 | 7 | 620.90 | 88.70 | 100.0% | 3.8 |
| 1-2 | 6 | 400.20 | 66.70 | 100.0% | 18.6 |
| >=20 | 2 | 71.00 | 35.50 | 100.0% | 37.6 |

## By ES Rolling High Minutes Since

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 20-30 | 35 | 2266.40 | 64.75 | 100.0% | 8.7 |
| <1 | 25 | 1879.70 | 75.19 | 100.0% | 15.0 |
| 10-20 | 13 | 674.60 | 51.89 | 100.0% | 12.0 |
| 5-10 | 13 | 1326.50 | 102.04 | 100.0% | 8.8 |
| 1-3 | 11 | 650.60 | 59.15 | 100.0% | 20.6 |
| 3-5 | 10 | 505.30 | 50.53 | 100.0% | 10.2 |
| 30-60 | 1 | 66.50 | 66.50 | 100.0% | 12.0 |

## By RSI Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| >=3 | 34 | 2393.30 | 70.39 | 100.0% | 12.0 |
| 0-1 | 24 | 1229.60 | 51.23 | 100.0% | 11.2 |
| -3--2 | 8 | 829.00 | 103.63 | 100.0% | 10.2 |
| <-3 | 8 | 356.70 | 44.59 | 100.0% | 9.3 |
| -1-0 | 7 | 552.80 | 78.97 | 100.0% | 12.0 |
| -2--1 | 7 | 514.60 | 73.51 | 100.0% | 12.0 |
| 1-2 | 7 | 489.00 | 69.86 | 100.0% | 15.0 |
| 2-3 | 7 | 563.20 | 80.46 | 100.0% | 12.1 |
| missing | 6 | 441.40 | 73.57 | 100.0% | 8.4 |

## By ADX Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-1 | 38 | 2396.90 | 63.08 | 100.0% | 13.4 |
| -1-0 | 36 | 2902.00 | 80.61 | 100.0% | 12.0 |
| 1-2 | 20 | 1327.20 | 66.36 | 100.0% | 7.8 |
| -2--1 | 8 | 302.10 | 37.76 | 100.0% | 21.3 |
| missing | 6 | 441.40 | 73.57 | 100.0% | 8.4 |

## By ES Higher-Low Distance Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 2-4 | 34 | 2336.50 | 68.72 | 100.0% | 13.8 |
| 4-8 | 21 | 1886.90 | 89.85 | 100.0% | 9.9 |
| 1-2 | 19 | 1100.40 | 57.92 | 100.0% | 8.4 |
| >=8 | 18 | 1198.20 | 66.57 | 100.0% | 15.9 |
| 0-0.5 | 10 | 469.80 | 46.98 | 100.0% | 4.5 |
| 0.5-1 | 6 | 377.80 | 62.97 | 100.0% | 14.0 |

## By ES Structure Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 3 | 39 | 2478.10 | 63.54 | 100.0% | 12.0 |
| 4 | 36 | 2436.70 | 67.69 | 100.0% | 13.4 |
| 5 | 32 | 2420.80 | 75.65 | 100.0% | 11.9 |
| 2 | 1 | 34.00 | 34.00 | 100.0% | 12.1 |

## By ES Structure Pullback From High

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-2 | 48 | 3518.40 | 73.30 | 100.0% | 12.6 |
| 2-4 | 30 | 1667.90 | 55.60 | 100.0% | 11.9 |
| 4-8 | 24 | 1849.20 | 77.05 | 100.0% | 7.8 |
| 8-12 | 4 | 160.10 | 40.02 | 100.0% | 14.7 |
| 12-16 | 2 | 174.00 | 87.00 | 100.0% | 6.0 |

## By ES Structure Higher-Low Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 42 | 2575.60 | 61.32 | 100.0% | 12.0 |
| 2-4 | 17 | 637.50 | 37.50 | 100.0% | 20.0 |
| 0.5-1 | 12 | 990.80 | 82.57 | 100.0% | 4.8 |
| 1-2 | 12 | 896.50 | 74.71 | 100.0% | 11.9 |
| 4-8 | 10 | 1029.60 | 102.96 | 100.0% | 12.0 |
| >=8 | 8 | 701.50 | 87.69 | 100.0% | 12.0 |
| 0-0.5 | 7 | 538.10 | 76.87 | 100.0% | 9.7 |

## By ES Structure Higher-High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 41 | 2577.90 | 62.88 | 100.0% | 8.7 |
| 2-4 | 18 | 1619.30 | 89.96 | 100.0% | 3.7 |
| 1-2 | 15 | 947.70 | 63.18 | 100.0% | 20.0 |
| 4-8 | 15 | 1098.30 | 73.22 | 100.0% | 13.2 |
| >=8 | 9 | 561.40 | 62.38 | 100.0% | 14.7 |
| 0-0.5 | 6 | 312.10 | 52.02 | 100.0% | 16.9 |
| 0.5-1 | 4 | 252.90 | 63.23 | 100.0% | 10.4 |

## By ES Structure VWAP Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 38 | 2677.40 | 70.46 | 100.0% | 13.9 |
| >=24 | 25 | 1392.60 | 55.70 | 100.0% | 2.3 |
| 8-12 | 14 | 1276.30 | 91.16 | 100.0% | 17.7 |
| 12-16 | 10 | 648.30 | 64.83 | 100.0% | 12.0 |
| 2-4 | 9 | 629.50 | 69.94 | 100.0% | 12.0 |
| 16-24 | 8 | 518.20 | 64.77 | 100.0% | 10.2 |
| 0-2 | 4 | 227.30 | 56.82 | 100.0% | 11.9 |

## By Setup Quality Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 50-60 | 36 | 2370.20 | 65.84 | 100.0% | 7.5 |
| 60-70 | 23 | 1302.20 | 56.62 | 100.0% | 12.0 |
| 70-80 | 22 | 1935.10 | 87.96 | 100.0% | 12.1 |
| 40-50 | 17 | 1251.40 | 73.61 | 100.0% | 12.7 |
| 80-90 | 10 | 510.70 | 51.07 | 100.0% | 18.9 |

## By Entry-Veto Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 1-2 | 24 | 1698.60 | 70.78 | 100.0% | 12.1 |
| 3-4 | 23 | 1464.90 | 63.69 | 100.0% | 12.0 |
| 2-3 | 20 | 1405.10 | 70.26 | 100.0% | 16.1 |
| 5-6 | 17 | 993.50 | 58.44 | 100.0% | 7.3 |
| 4-5 | 15 | 1062.20 | 70.81 | 100.0% | 5.5 |
| <1 | 9 | 745.30 | 82.81 | 100.0% | 12.0 |

## By Slow-Risk Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <1 | 108 | 7369.60 | 68.24 | 100.0% | 12.0 |

## By Entry Risk Tier

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| standard | 108 | 7369.60 | 68.24 | 100.0% | 12.0 |

## By ES Reclaim Current Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 38 | 2677.40 | 70.46 | 100.0% | 13.9 |
| >=24 | 25 | 1392.60 | 55.70 | 100.0% | 2.3 |
| 8-12 | 14 | 1276.30 | 91.16 | 100.0% | 17.7 |
| 12-16 | 10 | 648.30 | 64.83 | 100.0% | 12.0 |
| 2-4 | 9 | 629.50 | 69.94 | 100.0% | 12.0 |
| 16-24 | 8 | 518.20 | 64.77 | 100.0% | 10.2 |
| 0-2 | 4 | 227.30 | 56.82 | 100.0% | 11.9 |

## By SPX EMA20 Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 68 | 4029.00 | 59.25 | 100.0% | 8.6 |
| 2-4 | 13 | 966.30 | 74.33 | 100.0% | 15.0 |
| 4-6 | 8 | 592.10 | 74.01 | 100.0% | 10.9 |
| 8-12 | 5 | 650.10 | 130.02 | 100.0% | 12.1 |
| >=12 | 5 | 230.80 | 46.16 | 100.0% | 16.6 |
| 1-2 | 4 | 142.00 | 35.50 | 100.0% | 54.7 |
| 6-8 | 3 | 118.80 | 39.60 | 100.0% | 23.6 |
| 0-1 | 2 | 640.50 | 320.25 | 100.0% | 66.2 |

## By Hold-Time Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 5-15 | 39 | 3329.40 | 85.37 | 100.0% | 11.9 |
| 15-30 | 28 | 921.30 | 32.90 | 100.0% | 19.5 |
| <5 | 28 | 2145.90 | 76.64 | 100.0% | 1.4 |
| 60-180 | 7 | 767.50 | 109.64 | 100.0% | 112.5 |
| 30-60 | 6 | 205.50 | 34.25 | 100.0% | 41.3 |

## By VIX Regime

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| disabled | 108 | 7369.60 | 68.24 | 100.0% | 12.0 |

## By Option Data State

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 82 | 5684.10 | 69.32 | 100.0% | 12.0 |
| VALID_1DTE_ONLY | 20 | 1315.30 | 65.76 | 100.0% | 14.1 |
| STALE_0DTE | 5 | 162.80 | 32.56 | 100.0% | 23.3 |
| EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 |

## By Active Profile Set

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 82 | 5684.10 | 69.32 | 100.0% | 12.0 |
| VALID_1DTE_ONLY | 20 | 1315.30 | 65.76 | 100.0% | 14.1 |
| STALE_0DTE | 5 | 162.80 | 32.56 | 100.0% | 23.3 |
| EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 |

## Monthly Summary

| Month | Trades | PnL | Avg PnL | Median Hold Min | Exposure Hours | PnL/Exposure Hour | Slow >=12h |
| --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| 2026-06 | 66 | 4608.20 | 69.82 | 10.9 | 16.4 | 281.76 | 0 |
| 2026-07 | 42 | 2761.40 | 65.75 | 12.9 | 17.8 | 155.01 | 0 |

## TP Target Distribution

| Target | Trades | PnL | Avg PnL | Median Hold Min |
| --- | ---: | ---: | ---: | ---: |
| 2.34 | 1 | 86.40 | 86.40 | 3.0 |
| 2.40 | 32 | 1271.80 | 39.74 | 4.2 |
| 2.49 | 1 | 45.50 | 45.50 | 20.6 |
| 2.57 | 1 | 93.60 | 93.60 | 5.3 |
| 2.63 | 1 | 39.60 | 39.60 | 12.0 |
| 2.83 | 1 | 36.00 | 36.00 | 56.0 |
| 2.99 | 1 | 105.00 | 105.00 | 8.5 |
| 3.00 | 20 | 1315.30 | 65.76 | 14.1 |
| 3.02 | 2 | 147.60 | 73.80 | 49.9 |
| 3.09 | 1 | 55.80 | 55.80 | 11.9 |
| 3.13 | 1 | 61.20 | 61.20 | 12.0 |
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
| 3.48 | 1 | 126.00 | 126.00 | 5.8 |
| 3.51 | 1 | 35.00 | 35.00 | 17.4 |
| 3.56 | 1 | 36.00 | 36.00 | 15.6 |
| 3.58 | 1 | 36.00 | 36.00 | 23.6 |
| 3.60 | 6 | 545.30 | 90.88 | 9.5 |
| 4.00 | 2 | 36.00 | 18.00 | 27.2 |
| 6.00 | 9 | 871.80 | 96.87 | 15.8 |
| 14.06 | 1 | 34.00 | 34.00 | 12.1 |
| 15.00 | 1 | 45.50 | 45.50 | 44.6 |
| 16.25 | 1 | 36.00 | 36.00 | 23.6 |
| 20.95 | 1 | 546.00 | 546.00 | 120.4 |
| 23.75 | 1 | 36.00 | 36.00 | 57.7 |
| 28.44 | 1 | 112.20 | 112.20 | 12.0 |
| 28.66 | 1 | 94.50 | 94.50 | 12.0 |
| 38.75 | 2 | 125.80 | 62.90 | 14.7 |
| 48.62 | 2 | 71.00 | 35.50 | 19.9 |
| 55.78 | 1 | 262.50 | 262.50 | 12.0 |

## Slow Trade Fingerprint
- Trades held >= 12 hours: 0 (0.0%)

## Interpretation Notes
- This strategy exits with take-profit orders only, so a high win rate can hide capital being tied up for a long time.
- The best setting candidates are usually found by reducing slow-to-profit entries, not simply maximizing raw entry count.
- Focus first on buckets with low average PnL or long median hold time, then test stricter RSI/ADX/VWAP/VIX filters against those buckets.
