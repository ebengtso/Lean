# SPX500 IB Trend Scalper Analysis

- Metrics file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_054/execution-metrics.csv`
- Backtest file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_054/launcher/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm.json`
- Completed paired trades: 103
- Entry signals: 103
- Approx open/unpaired entry signals: 0
- Position/order maintenance waits: 8206
- Total paired trade PnL: 7446.60
- Win rate: 100.0%
- Realized loss trades: 0
- Median hold: 12.0 minutes
- Average hold: 20.6 minutes

## Lean Runtime Statistics
- Equity: $107,446.60
- Net Profit: $7,446.60
- Return: 7.45 %
- Probabilistic Sharpe Ratio: 100.000%
- Volume: $45,421,635.60

## Risk And Efficiency
- Exposure hours: 35.4
- PnL per exposure hour: 210.16
- Calendar span days: 12.3
- PnL per calendar day: 604.55
- Trades per calendar day: 8.36
- Exposure share of calendar time: 12.0%
- Growth quality score: 11333.1
- VIX stale at entry: 0.0%
- ES stale rows: 9.3%
- Waiting ES VWAP rows: 0.0%
- Trade-health exit signals: 0
- Trade-health tighten signals: 0
- Slow trades held >= 12 hours: 0 (0.0%)
- Slow exposure hours: 0.0
- Slow PnL per exposure hour: 
- Fast <15m trades: 63
- Fast PnL per exposure hour: 764.36

## Pullback Broken Structure Veto
- Blocked signal rows: 1231
- Blocked by profile: `{"charm_pin_pullback_long": 1179, "pullback_long": 52}`
- Blocked net profit / worst MAE: not available for hard-blocked signals because they do not become completed trades.
- Remaining trades by profile: `{"breakout_long_1dte": 20, "breakout_long_no_0dte": 2, "call_wall_acceptance_long": 2, "charm_pin_pullback_long": 29, "charm_wall_breakaway_long": 5, "pullback_long": 31, "pullback_long_no_0dte": 4, "squeeze_long": 10}`
- Remaining PnL by profile: `{"breakout_long_1dte": 1315.299999999992, "breakout_long_no_0dte": 175.40000000001237, "call_wall_acceptance_long": 640.5, "charm_pin_pullback_long": 1076.2000000001144, "charm_wall_breakaway_long": 986.9999999999873, "pullback_long": 2419.4000000001934, "pullback_long_no_0dte": 109.79999999999018, "squeeze_long": 723.0000000000064}`

## Lean Portfolio And Trade Statistics
- Portfolio: sharpeRatio=35.0336, sortinoRatio=0, alpha=0, beta=0, informationRatio=35.6228, drawdown=0.007
- Trades: sharpeRatio=0.8920, averageMAE=-101.4408, averageMFE=91.8092, largestMAE=-655.2, largestMFE=592.8, maximumIntraTradeDrawdown=-1248.0

## Strategy Profile Performance

| Strategy | Enabled | Data State | Profile Set | Trades | PnL | Avg PnL | Win Rate | Median Hold Min | Exposure Hrs | PnL/Exposure Hr | Slow >=12h | Worst MAE | Median MFE | Median TP |
| --- | --- | --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| pullback_long | true | VALID_0DTE | VALID_0DTE | 31 | 2419.40 | 78.05 | 100.0% | 12.0 | 9.6 | 252.90 | 0 | -403.20 | 99.00 | 3.33 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 1315.30 | 65.76 | 100.0% | 14.1 | 7.7 | 170.09 | 0 | -386.75 | 79.88 | 3.00 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 29 | 1076.20 | 37.11 | 100.0% | 3.0 | 5.2 | 208.62 | 0 | -335.75 | 42.50 | 2.40 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 5 | 987.00 | 197.40 | 100.0% | 16.0 | 4.2 | 234.69 | 0 | -357.00 | 150.50 | 12.00 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 10 | 723.00 | 72.30 | 100.0% | 15.7 | 3.9 | 187.68 | 0 | -214.20 | 77.78 | 33.59 |
| call_wall_acceptance_long | true | VALID_0DTE | VALID_0DTE | 2 | 640.50 | 320.25 | 100.0% | 66.2 | 2.2 | 290.29 | 0 | -655.20 | 364.57 | 24.81 |
| breakout_long_no_0dte | true | EXPIRED_0DTE | EXPIRED_0DTE | 1 | 139.40 | 139.40 | 100.0% | 14.4 | 0.2 | 578.82 | 0 | -86.70 | 232.90 | 4.00 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 4 | 109.80 | 27.45 | 100.0% | 27.2 | 2.0 | 54.18 | 0 | -103.50 | 27.90 | 3.74 |
| breakout_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 1 | 36.00 | 36.00 | 100.0% | 26.5 | 0.4 | 81.41 | 0 | -117.00 | 52.20 | 4.00 |
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
| pullback_long | true | VALID_0DTE | VALID_0DTE | 31 | 50.03 | 6.44 | 49.20 | 20.59 | 18.5 | 0 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 66.60 | 5.83 | 70.56 | 26.99 | 23.2 | 0 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 29 | 66.79 | 29.61 | 48.91 | 20.35 | 10.7 | 0 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 5 | 75.96 | 21.06 | 57.99 | 17.35 | 50.5 | 0 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 10 | 69.16 | 11.21 | 69.11 | 21.34 | 23.1 | 0 |
| call_wall_acceptance_long | true | VALID_0DTE | VALID_0DTE | 2 | 72.97 | 22.88 | 54.16 | 28.60 | 66.2 | 0 |
| breakout_long_no_0dte | true | EXPIRED_0DTE | EXPIRED_0DTE | 1 | 71.04 | 7.54 | 81.57 | 27.17 | 14.4 | 0 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 4 | 54.85 | 4.10 | 49.59 | 18.94 | 30.4 | 0 |
| breakout_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 1 | 67.20 | 5.05 | 61.87 | 31.04 | 26.5 | 0 |
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
- MAE: average -102.44, median -71.65, worst -655.20
- MFE: average 91.81, median 63.00, best 592.80
- Average MFE / absolute MAE: 0.90

## Intratrade Path
- Trades with path stats: 103; with intratrade price samples: 103
- Went positive before max adverse: 52.4%
- MFE happened before MAE: 9.7%
- TP touched before MAE: 1.0%
- Median MFE available before MAE: 0.05 points
- Median first TP touch: 3.0 minutes
- Median first +1.5 points: 2.8 minutes
- First 15m MFE/MAE medians: 2.40 / -1.95 points

## Worst Tail Trade Autopsy
- Worst tail entry: `2026-06-26T11:59:48+00:00` -> `2026-06-26T14:00:11+00:00`.
- Strategy/profile: `call_wall_acceptance_long` / `call_wall_acceptance_long`. PnL 546.00, MAE -655.20, MFE 592.80, hold 120.4 minutes.
- Profile context: `call_wall_acceptance_long` produced 2 trades, PnL 640.50, 0 slow >=12h trades, and 8.6% of total PnL.
- Entry state: setup=73.44, ES-VWAP=28.76, VWAP slope=0.0302, VWAP acceleration=-0.0176, RSI=54.73, ADX=14.45, structure score=5.00, higher-low=4.25, higher-high=3.00, pullback-from-high=4.50, rolling-high distance=4.50.
- Guard state: setup allowed=`True`, entry veto allowed=`True`, veto points=2.00, slow-risk points=0.00.
- Existing warning reason: RSI slope -2.5746 <= -2.0000; ADX 14.45 <= 18.00.
- Strategy selection reason: positive gamma call-wall acceptance: callPutVolumeImbalance=0.8914, callWall=7400.00, target=7458.20, distance=14.50, forwardDexRatio30m=0.6066.
- Intratrade path: path MFE 21.00, path MAE -22.70, MFE before MAE=`False`, TP reached=`True`.
- Surgical setup floor check: `setup_quality_score >= 73.5` would block this trade, keep 19 trades, retain 18.4% PnL, and leave worst MAE -386.75. It would block 84 trades total.
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
| `long_strategy != "breakout_long_1dte"` | 20 | 6 | 14 | 83 | 6131.30 | 1315.30 | 82.3% | -655.20 | 15799.8 |
| `strategy_profile != "breakout_long_1dte"` | 20 | 6 | 14 | 83 | 6131.30 | 1315.30 | 82.3% | -655.20 | 15799.8 |
| `es_structure_rising_vwap != "False"` | 20 | 6 | 13 | 84 | 6063.50 | 1383.10 | 81.4% | -655.20 | 15791.7 |
| `option_strike_map_selected_tp_source != "target_2_upper_straddle"` | 20 | 4 | 8 | 91 | 5417.10 | 2029.50 | 72.7% | -403.20 | 12527.5 |
| `path_half_tp_touch_minutes >= 0.183333` | 20 | 12 | 24 | 67 | 5675.30 | 1771.30 | 76.2% | -655.20 | 485.2 |
| `path_first_observed_seconds >= 2` | 20 | 5 | 17 | 81 | 6213.80 | 1232.80 | 83.4% | -655.20 | 102.6 |
| `es_structure_higher_low_distance >= -1` | 20 | 5 | 19 | 79 | 6110.80 | 1335.80 | 82.1% | -655.20 | 81.1 |
| `option_strike_map_target_1_strike >= 7475` | 20 | 5 | 8 | 90 | 5977.50 | 1469.10 | 80.3% | -403.20 | 73.6 |
| `option_strike_map_target_2_strike <= 7600.52` | 20 | 5 | 19 | 79 | 5903.60 | 1543.00 | 79.3% | -655.20 | 43.8 |
| `path_first_observed_points <= -0.2` | 20 | 6 | 23 | 74 | 5523.30 | 1923.30 | 74.2% | -655.20 | 39.3 |
| `path_first_nonzero_move_points <= -0.2` | 20 | 6 | 23 | 74 | 5523.30 | 1923.30 | 74.2% | -655.20 | 39.3 |
| `path_first_observed_seconds <= 9` | 20 | 6 | 24 | 73 | 5443.40 | 2003.20 | 73.1% | -403.20 | 23.4 |

## Upside TP Extension Candidates
| all | No upside TP extension candidates found. |  |  |  |  |  |  |  |  |  |  |

## Event Counts
- blocked: 36073
- position_wait: 8206
- stale_es_vwap: 4867
- trade_risk_extend_signal: 1504
- trade_risk_tighten_signal: 619
- order_event: 466
- waiting_spx_quote: 415
- entry_signal: 103

## Blocked Gate Counts
- setup_quality_allowed: 14446 (disabled=14446)
- above_vwap_confirmed: 9087 (disabled=9087)
- above_vwap: 8082 (disabled=8082)
- es_structure_allowed: 7809 (disabled=7809)
- pullback: 6650 (disabled=6650)
- momentum: 4192 (disabled=4192)
- es_vwap_max_distance_allowed: 3867 (disabled=3867)
- es_vwap_slope_allowed: 3680 (disabled=3680)
- trend_strength: 3392 (disabled=3392)
- es_vwap_acceleration_allowed: 1891 (disabled=1891)
- es_rolling_high_allowed: 492 (disabled=492)
- indicator_slope_allowed: 154 (disabled=154)

## By UTC Hour

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 13 | 12 | 735.60 | 61.30 | 100.0% | 0.4 |
| 8 | 12 | 1326.10 | 110.51 | 100.0% | 20.1 |
| 14 | 10 | 856.80 | 85.68 | 100.0% | 2.1 |
| 1 | 6 | 515.30 | 85.88 | 100.0% | 3.0 |
| 15 | 6 | 368.10 | 61.35 | 100.0% | 9.2 |
| 11 | 5 | 707.20 | 141.44 | 100.0% | 12.0 |
| 12 | 5 | 229.30 | 45.86 | 100.0% | 12.2 |
| 18 | 5 | 296.80 | 59.36 | 100.0% | 12.0 |
| 19 | 5 | 276.20 | 55.24 | 100.0% | 8.4 |
| 5 | 5 | 245.10 | 49.02 | 100.0% | 20.6 |
| 6 | 5 | 243.10 | 48.62 | 100.0% | 16.4 |
| 9 | 5 | 289.80 | 57.96 | 100.0% | 12.0 |
| 2 | 4 | 214.50 | 53.63 | 100.0% | 48.6 |
| 22 | 4 | 325.90 | 81.48 | 100.0% | 14.7 |
| 7 | 4 | 243.40 | 60.85 | 100.0% | 12.0 |
| 0 | 3 | 178.50 | 59.50 | 100.0% | 12.1 |
| 10 | 2 | 55.40 | 27.70 | 100.0% | 18.4 |
| 23 | 2 | 70.00 | 35.00 | 100.0% | 29.5 |
| 3 | 2 | 150.50 | 75.25 | 100.0% | 15.9 |
| 17 | 1 | 119.00 | 119.00 | 100.0% | 7.3 |

## By RSI Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <55 | 55 | 3825.00 | 69.55 | 100.0% | 7.3 |
| 55-60 | 17 | 1362.90 | 80.17 | 100.0% | 14.0 |
| >=75 | 10 | 912.70 | 91.27 | 100.0% | 7.8 |
| 60-65 | 8 | 389.00 | 48.63 | 100.0% | 28.0 |
| 70-75 | 8 | 414.00 | 51.75 | 100.0% | 18.7 |
| 65-70 | 5 | 543.00 | 108.60 | 100.0% | 16.4 |

## By ADX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <20 | 42 | 3337.90 | 79.47 | 100.0% | 10.3 |
| 20-25 | 21 | 1673.10 | 79.67 | 100.0% | 12.2 |
| 30-40 | 20 | 1202.50 | 60.12 | 100.0% | 12.0 |
| 25-30 | 15 | 927.60 | 61.84 | 100.0% | 12.0 |
| 40-50 | 4 | 265.90 | 66.48 | 100.0% | 17.4 |
| >=50 | 1 | 39.60 | 39.60 | 100.0% | 17.0 |

## By VIX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| missing | 103 | 7446.60 | 72.30 | 100.0% | 12.0 |

## By ES VWAP Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.25 | 99 | 6865.10 | 69.34 | 100.0% | 12.0 |
| 0.25-0.5 | 3 | 564.50 | 188.17 | 100.0% | 9.4 |
| 0.5-1 | 1 | 17.00 | 17.00 | 100.0% | 29.9 |

## By ES VWAP Acceleration Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.05 | 50 | 3276.10 | 65.52 | 100.0% | 12.1 |
| -0.05-0 | 34 | 2784.80 | 81.91 | 100.0% | 7.8 |
| 0.1-0.25 | 9 | 935.70 | 103.97 | 100.0% | 14.4 |
| 0.05-0.1 | 6 | 291.50 | 48.58 | 100.0% | 20.5 |
| >=0.25 | 2 | 53.00 | 26.50 | 100.0% | 28.2 |
| -0.1--0.05 | 1 | 18.00 | 18.00 | 100.0% | 55.4 |
| -0.25--0.1 | 1 | 87.50 | 87.50 | 100.0% | 6.7 |

## By ES Rolling High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-6 | 29 | 2044.90 | 70.51 | 100.0% | 5.8 |
| 2-4 | 21 | 1176.70 | 56.03 | 100.0% | 15.3 |
| 0-1 | 20 | 1576.20 | 78.81 | 100.0% | 13.8 |
| 6-8 | 13 | 1389.70 | 106.90 | 100.0% | 12.1 |
| 8-12 | 9 | 412.00 | 45.78 | 100.0% | 17.3 |
| 1-2 | 5 | 365.20 | 73.04 | 100.0% | 16.5 |
| 12-20 | 5 | 446.90 | 89.38 | 100.0% | 3.8 |
| >=20 | 1 | 35.00 | 35.00 | 100.0% | 19.1 |

## By ES Rolling High Minutes Since

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 20-30 | 34 | 2460.80 | 72.38 | 100.0% | 8.0 |
| <1 | 23 | 1729.90 | 75.21 | 100.0% | 14.4 |
| 10-20 | 12 | 653.00 | 54.42 | 100.0% | 12.3 |
| 5-10 | 12 | 1170.50 | 97.54 | 100.0% | 10.3 |
| 1-3 | 11 | 860.60 | 78.24 | 100.0% | 20.6 |
| 3-5 | 10 | 505.30 | 50.53 | 100.0% | 10.2 |
| 30-60 | 1 | 66.50 | 66.50 | 100.0% | 12.0 |

## By RSI Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| >=3 | 33 | 2499.30 | 75.74 | 100.0% | 12.0 |
| 0-1 | 20 | 1027.80 | 51.39 | 100.0% | 6.0 |
| -3--2 | 8 | 829.00 | 103.63 | 100.0% | 10.2 |
| 1-2 | 8 | 525.00 | 65.62 | 100.0% | 15.8 |
| -1-0 | 7 | 552.80 | 78.97 | 100.0% | 12.0 |
| -2--1 | 7 | 514.60 | 73.51 | 100.0% | 12.0 |
| <-3 | 7 | 335.10 | 47.87 | 100.0% | 6.7 |
| missing | 7 | 459.40 | 65.63 | 100.0% | 8.5 |
| 2-3 | 6 | 703.60 | 117.27 | 100.0% | 17.8 |

## By ADX Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-1 | 35 | 2372.10 | 67.77 | 100.0% | 12.0 |
| -1-0 | 33 | 3039.80 | 92.12 | 100.0% | 12.0 |
| 1-2 | 20 | 1273.20 | 63.66 | 100.0% | 7.8 |
| -2--1 | 8 | 302.10 | 37.76 | 100.0% | 21.3 |
| missing | 7 | 459.40 | 65.63 | 100.0% | 8.5 |

## By ES Higher-Low Distance Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 2-4 | 34 | 2270.50 | 66.78 | 100.0% | 15.1 |
| 4-8 | 20 | 2237.30 | 111.86 | 100.0% | 10.9 |
| 1-2 | 18 | 1078.80 | 59.93 | 100.0% | 7.8 |
| >=8 | 15 | 1012.40 | 67.49 | 100.0% | 14.4 |
| 0-0.5 | 10 | 469.80 | 46.98 | 100.0% | 4.5 |
| 0.5-1 | 6 | 377.80 | 62.97 | 100.0% | 14.0 |

## By ES Structure Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 3 | 35 | 2686.90 | 76.77 | 100.0% | 12.0 |
| 4 | 35 | 2304.90 | 65.85 | 100.0% | 12.0 |
| 5 | 32 | 2420.80 | 75.65 | 100.0% | 11.9 |
| 2 | 1 | 34.00 | 34.00 | 100.0% | 12.1 |

## By ES Structure Pullback From High

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-2 | 46 | 3599.00 | 78.24 | 100.0% | 12.6 |
| 2-4 | 28 | 1595.90 | 57.00 | 100.0% | 11.9 |
| 4-8 | 24 | 2059.20 | 85.80 | 100.0% | 8.5 |
| 8-12 | 5 | 192.50 | 38.50 | 100.0% | 26.5 |

## By ES Structure Higher-Low Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 37 | 2723.20 | 73.60 | 100.0% | 12.1 |
| 2-4 | 17 | 637.50 | 37.50 | 100.0% | 20.0 |
| 1-2 | 12 | 828.50 | 69.04 | 100.0% | 11.9 |
| 0.5-1 | 11 | 969.20 | 88.11 | 100.0% | 3.8 |
| 4-8 | 11 | 1047.60 | 95.24 | 100.0% | 12.0 |
| 0-0.5 | 8 | 574.10 | 71.76 | 100.0% | 10.8 |
| >=8 | 7 | 666.50 | 95.21 | 100.0% | 12.0 |

## By ES Structure Higher-High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 39 | 2750.70 | 70.53 | 100.0% | 8.5 |
| 2-4 | 18 | 1829.30 | 101.63 | 100.0% | 6.9 |
| 4-8 | 15 | 1069.50 | 71.30 | 100.0% | 13.2 |
| 1-2 | 14 | 857.70 | 61.26 | 100.0% | 21.8 |
| >=8 | 8 | 458.40 | 57.30 | 100.0% | 13.3 |
| 0-0.5 | 5 | 228.10 | 45.62 | 100.0% | 17.4 |
| 0.5-1 | 4 | 252.90 | 63.23 | 100.0% | 10.4 |

## By ES Structure VWAP Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 39 | 2645.40 | 67.83 | 100.0% | 14.4 |
| >=24 | 25 | 1392.60 | 55.70 | 100.0% | 2.3 |
| 8-12 | 12 | 1435.70 | 119.64 | 100.0% | 17.8 |
| 2-4 | 9 | 611.50 | 67.94 | 100.0% | 12.0 |
| 12-16 | 7 | 427.50 | 61.07 | 100.0% | 12.0 |
| 16-24 | 7 | 706.60 | 100.94 | 100.0% | 9.4 |
| 0-2 | 4 | 227.30 | 56.82 | 100.0% | 11.9 |

## By Setup Quality Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 50-60 | 34 | 2408.60 | 70.84 | 100.0% | 7.5 |
| 60-70 | 23 | 1316.60 | 57.24 | 100.0% | 12.0 |
| 70-80 | 20 | 1994.30 | 99.72 | 100.0% | 12.0 |
| 40-50 | 17 | 1251.40 | 73.61 | 100.0% | 12.7 |
| 80-90 | 9 | 475.70 | 52.86 | 100.0% | 16.6 |

## By Entry-Veto Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 1-2 | 23 | 1595.60 | 69.37 | 100.0% | 12.0 |
| 3-4 | 22 | 1418.10 | 64.46 | 100.0% | 11.9 |
| 2-3 | 21 | 1423.10 | 67.77 | 100.0% | 16.1 |
| 4-5 | 14 | 1466.60 | 104.76 | 100.0% | 7.5 |
| 5-6 | 14 | 797.90 | 56.99 | 100.0% | 7.2 |
| <1 | 9 | 745.30 | 82.81 | 100.0% | 12.0 |

## By Slow-Risk Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <1 | 103 | 7446.60 | 72.30 | 100.0% | 12.0 |

## By Entry Risk Tier

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| standard | 103 | 7446.60 | 72.30 | 100.0% | 12.0 |

## By ES Reclaim Current Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 39 | 2645.40 | 67.83 | 100.0% | 14.4 |
| >=24 | 25 | 1392.60 | 55.70 | 100.0% | 2.3 |
| 8-12 | 12 | 1435.70 | 119.64 | 100.0% | 17.8 |
| 2-4 | 9 | 611.50 | 67.94 | 100.0% | 12.0 |
| 12-16 | 7 | 427.50 | 61.07 | 100.0% | 12.0 |
| 16-24 | 7 | 706.60 | 100.94 | 100.0% | 9.4 |
| 0-2 | 4 | 227.30 | 56.82 | 100.0% | 11.9 |

## By SPX EMA20 Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 65 | 4025.40 | 61.93 | 100.0% | 8.7 |
| 2-4 | 13 | 1196.70 | 92.05 | 100.0% | 24.9 |
| 4-6 | 9 | 628.10 | 69.79 | 100.0% | 12.0 |
| 8-12 | 5 | 582.10 | 116.42 | 100.0% | 12.1 |
| 1-2 | 4 | 142.00 | 35.50 | 100.0% | 54.7 |
| >=12 | 3 | 159.80 | 53.27 | 100.0% | 16.0 |
| 0-1 | 2 | 640.50 | 320.25 | 100.0% | 66.2 |
| 6-8 | 2 | 72.00 | 36.00 | 100.0% | 40.7 |

## By Hold-Time Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 5-15 | 37 | 3350.20 | 90.55 | 100.0% | 11.9 |
| 15-30 | 27 | 875.50 | 32.43 | 100.0% | 20.0 |
| <5 | 26 | 1851.90 | 71.23 | 100.0% | 1.0 |
| 30-60 | 6 | 187.50 | 31.25 | 100.0% | 41.3 |
| 60-180 | 6 | 731.50 | 121.92 | 100.0% | 116.4 |
| 180-720 | 1 | 450.00 | 450.00 | 100.0% | 198.3 |

## By VIX Regime

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| disabled | 103 | 7446.60 | 72.30 | 100.0% | 12.0 |

## By Option Data State

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 77 | 5846.10 | 75.92 | 100.0% | 12.0 |
| VALID_1DTE_ONLY | 20 | 1315.30 | 65.76 | 100.0% | 14.1 |
| STALE_0DTE | 5 | 145.80 | 29.16 | 100.0% | 26.5 |
| EXPIRED_0DTE | 1 | 139.40 | 139.40 | 100.0% | 14.4 |

## By Active Profile Set

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 77 | 5846.10 | 75.92 | 100.0% | 12.0 |
| VALID_1DTE_ONLY | 20 | 1315.30 | 65.76 | 100.0% | 14.1 |
| STALE_0DTE | 5 | 145.80 | 29.16 | 100.0% | 26.5 |
| EXPIRED_0DTE | 1 | 139.40 | 139.40 | 100.0% | 14.4 |

## Monthly Summary

| Month | Trades | PnL | Avg PnL | Median Hold Min | Exposure Hours | PnL/Exposure Hour | Slow >=12h |
| --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| 2026-06 | 64 | 4631.20 | 72.36 | 10.9 | 16.0 | 288.70 | 0 |
| 2026-07 | 39 | 2815.40 | 72.19 | 15.6 | 19.4 | 145.19 | 0 |

## TP Target Distribution

| Target | Trades | PnL | Avg PnL | Median Hold Min |
| --- | ---: | ---: | ---: | ---: |
| 2.34 | 1 | 86.40 | 86.40 | 3.0 |
| 2.40 | 29 | 1076.20 | 37.11 | 3.0 |
| 2.49 | 1 | 45.50 | 45.50 | 20.6 |
| 2.57 | 1 | 93.60 | 93.60 | 5.3 |
| 2.63 | 1 | 39.60 | 39.60 | 12.0 |
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
| 3.48 | 2 | 144.00 | 72.00 | 30.6 |
| 3.51 | 1 | 35.00 | 35.00 | 17.4 |
| 3.56 | 1 | 36.00 | 36.00 | 15.6 |
| 3.58 | 1 | 36.00 | 36.00 | 23.6 |
| 3.60 | 6 | 545.30 | 90.88 | 9.5 |
| 4.00 | 4 | 211.40 | 52.85 | 21.4 |
| 12.00 | 5 | 987.00 | 197.40 | 16.0 |
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
