# SPX500 IB Trend Scalper Analysis

- Metrics file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_036/execution-metrics.csv`
- Backtest file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_036/launcher/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm.json`
- Completed paired trades: 105
- Entry signals: 105
- Approx open/unpaired entry signals: 0
- Position/order maintenance waits: 8156
- Total paired trade PnL: 7084.90
- Win rate: 100.0%
- Realized loss trades: 0
- Median hold: 12.0 minutes
- Average hold: 20.1 minutes

## Lean Runtime Statistics
- Equity: $107,084.90
- Net Profit: $7,084.90
- Return: 7.08 %
- Probabilistic Sharpe Ratio: 100.000%
- Volume: $45,871,046.30

## Risk And Efficiency
- Exposure hours: 35.2
- PnL per exposure hour: 201.13
- Calendar span days: 12.3
- PnL per calendar day: 575.19
- Trades per calendar day: 8.52
- Exposure share of calendar time: 11.9%
- Growth quality score: 11100.8
- VIX stale at entry: 0.0%
- ES stale rows: 9.4%
- Waiting ES VWAP rows: 0.0%
- Trade-health exit signals: 0
- Trade-health tighten signals: 0
- Slow trades held >= 12 hours: 0 (0.0%)
- Slow exposure hours: 0.0
- Slow PnL per exposure hour: 
- Fast <15m trades: 65
- Fast PnL per exposure hour: 765.07

## Pullback Broken Structure Veto
- Blocked signal rows: 1116
- Blocked by profile: `{"charm_pin_pullback_long": 1064, "pullback_long": 52}`
- Blocked net profit / worst MAE: not available for hard-blocked signals because they do not become completed trades.
- Remaining trades by profile: `{"breakout_long_1dte": 20, "breakout_long_no_0dte": 3, "call_wall_acceptance_long": 1, "charm_pin_pullback_long": 32, "charm_wall_breakaway_long": 5, "pullback_long": 31, "pullback_long_no_0dte": 3, "squeeze_long": 10}`
- Remaining PnL by profile: `{"breakout_long_1dte": 1304.999999999991, "breakout_long_no_0dte": 278.40000000001237, "call_wall_acceptance_long": 91.0, "charm_pin_pullback_long": 1200.3000000001175, "charm_wall_breakaway_long": 985.5999999999876, "pullback_long": 2411.800000000194, "pullback_long_no_0dte": 91.79999999999018, "squeeze_long": 721.0000000000064}`

## Lean Portfolio And Trade Statistics
- Portfolio: sharpeRatio=31.4298, sortinoRatio=0, alpha=0, beta=0, informationRatio=32.0108, drawdown=0.004
- Trades: sharpeRatio=1.0173, averageMAE=-100.5629, averageMFE=86.1652, largestMAE=-513.4, largestMFE=462.60, maximumIntraTradeDrawdown=-564.4

## Strategy Profile Performance

| Strategy | Enabled | Data State | Profile Set | Trades | PnL | Avg PnL | Win Rate | Median Hold Min | Exposure Hrs | PnL/Exposure Hr | Slow >=12h | Worst MAE | Median MFE | Median TP |
| --- | --- | --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| pullback_long | true | VALID_0DTE | VALID_0DTE | 31 | 2411.80 | 77.80 | 100.0% | 12.0 | 9.6 | 252.10 | 0 | -403.20 | 98.00 | 3.33 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 1305.00 | 65.25 | 100.0% | 14.1 | 7.7 | 168.76 | 0 | -375.70 | 79.88 | 3.00 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 32 | 1200.30 | 37.51 | 100.0% | 5.0 | 6.6 | 182.79 | 0 | -513.40 | 42.50 | 2.40 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 5 | 985.60 | 197.12 | 100.0% | 16.0 | 4.2 | 234.36 | 0 | -346.80 | 146.20 | 12.00 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 10 | 721.00 | 72.10 | 100.0% | 15.7 | 3.9 | 187.16 | 0 | -208.25 | 77.78 | 33.59 |
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
| pullback_long | true | VALID_0DTE | VALID_0DTE | 31 | 50.03 | 6.44 | 49.20 | 20.59 | 18.5 | 0 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 66.60 | 5.83 | 70.56 | 26.99 | 23.2 | 0 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 32 | 66.16 | 29.56 | 49.67 | 18.92 | 12.3 | 0 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 5 | 75.96 | 21.06 | 57.99 | 17.35 | 50.5 | 0 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 10 | 69.16 | 11.21 | 69.11 | 21.34 | 23.1 | 0 |
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
- MAE: average -101.53, median -71.65, worst -513.40
- MFE: average 86.17, median 61.25, best 462.60
- Average MFE / absolute MAE: 0.85

## Intratrade Path
- Trades with path stats: 105; with intratrade price samples: 105
- Went positive before max adverse: 53.3%
- MFE happened before MAE: 9.5%
- TP touched before MAE: 1.0%
- Median MFE available before MAE: 0.05 points
- Median first TP touch: 3.8 minutes
- Median first +1.5 points: 2.9 minutes
- First 15m MFE/MAE medians: 2.40 / -1.90 points

## Worst Tail Trade Autopsy
- Worst tail entry: `2026-06-26T12:36:24+00:00` -> `2026-06-26T13:56:26+00:00`.
- Strategy/profile: `charm_pin_pullback_long` / `charm_pin_pullback_long`. PnL 42.50, MAE -513.40, MFE 51.00, hold 80.0 minutes.
- Profile context: `charm_pin_pullback_long` produced 32 trades, PnL 1200.30, 0 slow >=12h trades, and 16.9% of total PnL.
- Entry state: setup=61.77, ES-VWAP=26.69, VWAP slope=0.0417, VWAP acceleration=-0.0179, RSI=42.42, ADX=17.95, structure score=4.00, higher-low=0.2500, higher-high=3.75, pullback-from-high=9.25, rolling-high distance=14.25.
- Guard state: setup allowed=`True`, entry veto allowed=`True`, veto points=4.00, slow-risk points=0.00.
- Existing warning reason: ES pullback from high 9.25 >= 5.00; RSI slope -3.8597 <= -2.0000; ADX 17.95 <= 18.00; RSI 42.42 <= 45.00.
- Strategy selection reason: positive gamma/charm pin pullback: expectedMovePosition=0.0105, netCharm30m=-25186308, lowerFade=False, pullback=True, dynamicMaxVwapDistance=17.89.
- Intratrade path: path MFE 2.50, path MAE -27.70, MFE before MAE=`False`, TP reached=`True`.
- Surgical setup floor check: `setup_quality_score >= 61.8` would block this trade, keep 51 trades, retain 46.5% PnL, and leave worst MAE -375.70. It would block 54 trades total.
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
| `es_structure_rising_vwap != "False"` | 20 | 7 | 13 | 85 | 5605.30 | 1479.60 | 79.1% | -513.40 | 12439.9 |
| `long_strategy != "breakout_long_1dte"` | 20 | 6 | 14 | 85 | 5779.90 | 1305.00 | 81.6% | -513.40 | 12400.5 |
| `strategy_profile != "breakout_long_1dte"` | 20 | 6 | 14 | 85 | 5779.90 | 1305.00 | 81.6% | -513.40 | 12400.5 |
| `path_half_tp_touch_minutes >= 0.183333` | 20 | 12 | 24 | 69 | 5304.50 | 1780.40 | 74.9% | -513.40 | 483.5 |
| `es_structure_pullback_from_high <= 3.25` | 20 | 8 | 25 | 72 | 5168.40 | 1916.50 | 72.9% | -403.20 | 177.5 |
| `option_strike_map_atm_strike >= 7445` | 20 | 5 | 9 | 91 | 6119.00 | 965.90 | 86.4% | -403.20 | 162.6 |
| `option_strike_map_target_2_strike >= 7511.93` | 20 | 5 | 9 | 91 | 6119.00 | 965.90 | 86.4% | -403.20 | 162.6 |
| `option_strike_map_target_2_strike >= 7504.2` | 20 | 4 | 6 | 95 | 6398.80 | 686.10 | 90.3% | -403.20 | 147.5 |
| `es_structure_pullback_from_high <= 3.75` | 20 | 7 | 22 | 76 | 5312.90 | 1772.00 | 75.0% | -403.20 | 138.0 |
| `option_strike_map_atm_strike >= 7495` | 20 | 8 | 32 | 65 | 4973.30 | 2111.60 | 70.2% | -403.20 | 131.9 |
| `es_reclaim_samples <= 585` | 20 | 5 | 10 | 90 | 5824.00 | 1260.90 | 82.2% | -513.40 | 108.0 |
| `es_vwap >= 7454.42` | 20 | 5 | 13 | 87 | 5843.70 | 1241.20 | 82.5% | -403.20 | 107.1 |

## Upside TP Extension Candidates
| all | No upside TP extension candidates found. |  |  |  |  |  |  |  |  |  |  |

## Event Counts
- blocked: 36123
- position_wait: 8156
- stale_es_vwap: 4867
- trade_risk_extend_signal: 1192
- trade_risk_tighten_signal: 522
- order_event: 474
- waiting_spx_quote: 415
- entry_signal: 105

## Blocked Gate Counts
- setup_quality_allowed: 14470 (disabled=14470)
- above_vwap_confirmed: 9112 (disabled=9112)
- above_vwap: 8107 (disabled=8107)
- es_structure_allowed: 7897 (disabled=7897)
- pullback: 6257 (disabled=6257)
- es_vwap_slope_allowed: 4457 (disabled=4457)
- momentum: 4349 (disabled=4349)
- es_vwap_max_distance_allowed: 3905 (disabled=3905)
- trend_strength: 3238 (disabled=3238)
- es_vwap_acceleration_allowed: 2514 (disabled=2514)
- es_rolling_high_allowed: 742 (disabled=742)
- indicator_slope_allowed: 240 (disabled=240)

## By UTC Hour

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 13 | 12 | 735.60 | 61.30 | 100.0% | 0.4 |
| 8 | 11 | 1303.70 | 118.52 | 100.0% | 16.6 |
| 14 | 10 | 851.90 | 85.19 | 100.0% | 2.1 |
| 12 | 8 | 353.30 | 44.16 | 100.0% | 12.1 |
| 1 | 6 | 512.20 | 85.37 | 100.0% | 3.0 |
| 15 | 6 | 368.10 | 61.35 | 100.0% | 9.2 |
| 18 | 6 | 337.60 | 56.27 | 100.0% | 10.4 |
| 9 | 6 | 324.80 | 54.13 | 100.0% | 14.0 |
| 11 | 5 | 178.20 | 35.64 | 100.0% | 12.0 |
| 5 | 5 | 245.10 | 49.02 | 100.0% | 20.6 |
| 6 | 5 | 243.10 | 48.62 | 100.0% | 16.4 |
| 19 | 4 | 235.40 | 58.85 | 100.0% | 12.7 |
| 2 | 4 | 211.40 | 52.85 | 100.0% | 48.6 |
| 22 | 4 | 393.90 | 98.48 | 100.0% | 14.9 |
| 7 | 4 | 241.70 | 60.42 | 100.0% | 12.0 |
| 0 | 3 | 174.40 | 58.13 | 100.0% | 12.1 |
| 23 | 2 | 70.00 | 35.00 | 100.0% | 29.5 |
| 3 | 2 | 150.50 | 75.25 | 100.0% | 15.9 |
| 10 | 1 | 35.00 | 35.00 | 100.0% | 14.0 |
| 17 | 1 | 119.00 | 119.00 | 100.0% | 7.3 |

## By RSI Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <55 | 55 | 3357.00 | 61.04 | 100.0% | 7.1 |
| 55-60 | 17 | 1336.00 | 78.59 | 100.0% | 15.3 |
| >=75 | 11 | 1009.50 | 91.77 | 100.0% | 9.9 |
| 70-75 | 9 | 447.00 | 49.67 | 100.0% | 20.0 |
| 60-65 | 8 | 392.40 | 49.05 | 100.0% | 27.6 |
| 65-70 | 5 | 543.00 | 108.60 | 100.0% | 16.4 |

## By ADX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <20 | 43 | 2869.40 | 66.73 | 100.0% | 8.8 |
| 20-25 | 21 | 1665.50 | 79.31 | 100.0% | 12.2 |
| 25-30 | 18 | 1105.00 | 61.39 | 100.0% | 12.1 |
| 30-40 | 18 | 1124.00 | 62.44 | 100.0% | 12.0 |
| 40-50 | 4 | 281.40 | 70.35 | 100.0% | 8.4 |
| >=50 | 1 | 39.60 | 39.60 | 100.0% | 17.0 |

## By VIX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| missing | 105 | 7084.90 | 67.48 | 100.0% | 12.0 |

## By ES VWAP Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.25 | 101 | 6503.40 | 64.39 | 100.0% | 12.0 |
| 0.25-0.5 | 3 | 564.50 | 188.17 | 100.0% | 9.4 |
| 0.5-1 | 1 | 17.00 | 17.00 | 100.0% | 29.9 |

## By ES VWAP Acceleration Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.05 | 50 | 3285.50 | 65.71 | 100.0% | 12.0 |
| -0.05-0 | 36 | 2333.80 | 64.83 | 100.0% | 7.8 |
| 0.1-0.25 | 10 | 1037.70 | 103.77 | 100.0% | 15.7 |
| 0.05-0.1 | 6 | 287.40 | 47.90 | 100.0% | 20.5 |
| >=0.25 | 2 | 53.00 | 26.50 | 100.0% | 55.9 |
| -0.25--0.1 | 1 | 87.50 | 87.50 | 100.0% | 6.7 |

## By ES Rolling High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-6 | 29 | 1505.90 | 51.93 | 100.0% | 5.8 |
| 2-4 | 23 | 1249.40 | 54.32 | 100.0% | 15.3 |
| 0-1 | 20 | 1637.00 | 81.85 | 100.0% | 13.9 |
| 6-8 | 13 | 1411.80 | 108.60 | 100.0% | 9.4 |
| 8-12 | 8 | 397.00 | 49.62 | 100.0% | 13.0 |
| 1-2 | 6 | 400.20 | 66.70 | 100.0% | 18.6 |
| 12-20 | 5 | 448.60 | 89.72 | 100.0% | 6.6 |
| >=20 | 1 | 35.00 | 35.00 | 100.0% | 19.1 |

## By ES Rolling High Minutes Since

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 20-30 | 35 | 2490.50 | 71.16 | 100.0% | 8.7 |
| <1 | 24 | 1824.70 | 76.03 | 100.0% | 14.9 |
| 1-3 | 13 | 945.60 | 72.74 | 100.0% | 17.3 |
| 10-20 | 12 | 653.00 | 54.42 | 100.0% | 12.3 |
| 5-10 | 11 | 623.50 | 56.68 | 100.0% | 8.8 |
| 3-5 | 9 | 481.10 | 53.46 | 100.0% | 8.4 |
| 30-60 | 1 | 66.50 | 66.50 | 100.0% | 12.0 |

## By RSI Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| >=3 | 33 | 2549.70 | 77.26 | 100.0% | 12.1 |
| 0-1 | 21 | 1057.30 | 50.35 | 100.0% | 6.6 |
| -1-0 | 9 | 609.20 | 67.69 | 100.0% | 12.0 |
| -3--2 | 8 | 323.80 | 40.48 | 100.0% | 6.8 |
| <-3 | 8 | 398.30 | 49.79 | 100.0% | 5.8 |
| -2--1 | 7 | 514.60 | 73.51 | 100.0% | 12.0 |
| 1-2 | 7 | 488.00 | 69.71 | 100.0% | 15.0 |
| 2-3 | 6 | 702.60 | 117.10 | 100.0% | 17.8 |
| missing | 6 | 441.40 | 73.57 | 100.0% | 8.4 |

## By ADX Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-1 | 39 | 2591.20 | 66.44 | 100.0% | 12.0 |
| -1-0 | 33 | 2520.20 | 76.37 | 100.0% | 12.7 |
| 1-2 | 19 | 1231.70 | 64.83 | 100.0% | 7.3 |
| -2--1 | 8 | 300.40 | 37.55 | 100.0% | 21.3 |
| missing | 6 | 441.40 | 73.57 | 100.0% | 8.4 |

## By ES Higher-Low Distance Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 2-4 | 32 | 1700.60 | 53.14 | 100.0% | 13.8 |
| 4-8 | 21 | 2266.00 | 107.90 | 100.0% | 12.0 |
| 1-2 | 20 | 1136.60 | 56.83 | 100.0% | 7.8 |
| >=8 | 16 | 1112.00 | 69.50 | 100.0% | 15.3 |
| 0-0.5 | 9 | 449.40 | 49.93 | 100.0% | 1.9 |
| 0.5-1 | 7 | 420.30 | 60.04 | 100.0% | 11.9 |

## By ES Structure Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4 | 38 | 2508.50 | 66.01 | 100.0% | 12.0 |
| 3 | 35 | 2677.20 | 76.49 | 100.0% | 12.0 |
| 5 | 31 | 1865.20 | 60.17 | 100.0% | 11.9 |
| 2 | 1 | 34.00 | 34.00 | 100.0% | 12.1 |

## By ES Structure Pullback From High

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-2 | 47 | 3682.00 | 78.34 | 100.0% | 13.2 |
| 2-4 | 29 | 1630.90 | 56.24 | 100.0% | 11.9 |
| 4-8 | 24 | 1548.50 | 64.52 | 100.0% | 7.8 |
| 8-12 | 5 | 223.50 | 44.70 | 100.0% | 17.3 |

## By ES Structure Higher-Low Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 39 | 2790.30 | 71.55 | 100.0% | 12.1 |
| 2-4 | 17 | 636.50 | 37.44 | 100.0% | 20.0 |
| 0.5-1 | 11 | 969.20 | 88.11 | 100.0% | 3.8 |
| 1-2 | 11 | 852.60 | 77.51 | 100.0% | 12.0 |
| 4-8 | 10 | 540.60 | 54.06 | 100.0% | 7.4 |
| >=8 | 9 | 717.50 | 79.72 | 100.0% | 12.0 |
| 0-0.5 | 8 | 578.20 | 72.28 | 100.0% | 10.8 |

## By ES Structure Higher-High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 38 | 2701.20 | 71.08 | 100.0% | 8.6 |
| 2-4 | 19 | 1334.20 | 70.22 | 100.0% | 9.4 |
| 1-2 | 15 | 898.50 | 59.90 | 100.0% | 20.0 |
| 4-8 | 15 | 1111.00 | 74.07 | 100.0% | 12.0 |
| >=8 | 9 | 559.00 | 62.11 | 100.0% | 14.7 |
| 0-0.5 | 5 | 228.10 | 45.62 | 100.0% | 17.4 |
| 0.5-1 | 4 | 252.90 | 63.23 | 100.0% | 10.4 |

## By ES Structure VWAP Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 38 | 2665.70 | 70.15 | 100.0% | 13.9 |
| >=24 | 28 | 1011.50 | 36.13 | 100.0% | 2.7 |
| 8-12 | 14 | 1502.60 | 107.33 | 100.0% | 23.5 |
| 2-4 | 8 | 591.80 | 73.97 | 100.0% | 9.3 |
| 12-16 | 7 | 426.10 | 60.87 | 100.0% | 12.0 |
| 16-24 | 6 | 662.30 | 110.38 | 100.0% | 10.7 |
| 0-2 | 4 | 224.90 | 56.22 | 100.0% | 11.9 |

## By Setup Quality Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 50-60 | 33 | 2383.00 | 72.21 | 100.0% | 6.6 |
| 60-70 | 25 | 1371.30 | 54.85 | 100.0% | 12.0 |
| 70-80 | 19 | 1529.10 | 80.48 | 100.0% | 12.0 |
| 40-50 | 17 | 1251.40 | 73.61 | 100.0% | 12.7 |
| 80-90 | 11 | 550.10 | 50.01 | 100.0% | 16.6 |

## By Entry-Veto Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 1-2 | 23 | 1649.60 | 71.72 | 100.0% | 12.1 |
| 2-3 | 22 | 959.40 | 43.61 | 100.0% | 15.8 |
| 3-4 | 22 | 1430.80 | 65.04 | 100.0% | 10.3 |
| 4-5 | 15 | 1505.00 | 100.33 | 100.0% | 9.4 |
| 5-6 | 14 | 797.90 | 56.99 | 100.0% | 7.2 |
| <1 | 9 | 742.20 | 82.47 | 100.0% | 12.0 |

## By Slow-Risk Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <1 | 105 | 7084.90 | 67.48 | 100.0% | 12.0 |

## By Entry Risk Tier

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| standard | 105 | 7084.90 | 67.48 | 100.0% | 12.0 |

## By ES Reclaim Current Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 38 | 2665.70 | 70.15 | 100.0% | 13.9 |
| >=24 | 28 | 1011.50 | 36.13 | 100.0% | 2.7 |
| 8-12 | 14 | 1502.60 | 107.33 | 100.0% | 23.5 |
| 2-4 | 8 | 591.80 | 73.97 | 100.0% | 9.3 |
| 12-16 | 7 | 426.10 | 60.87 | 100.0% | 12.0 |
| 16-24 | 6 | 662.30 | 110.38 | 100.0% | 10.7 |
| 0-2 | 4 | 224.90 | 56.22 | 100.0% | 11.9 |

## By SPX EMA20 Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 67 | 4123.90 | 61.55 | 100.0% | 8.5 |
| 2-4 | 13 | 1193.60 | 91.82 | 100.0% | 24.9 |
| 4-6 | 8 | 583.50 | 72.94 | 100.0% | 10.9 |
| 8-12 | 5 | 650.10 | 130.02 | 100.0% | 12.1 |
| >=12 | 5 | 230.80 | 46.16 | 100.0% | 16.6 |
| 1-2 | 4 | 142.00 | 35.50 | 100.0% | 54.7 |
| 6-8 | 2 | 70.00 | 35.00 | 100.0% | 40.7 |
| 0-1 | 1 | 91.00 | 91.00 | 100.0% | 12.0 |

## By Hold-Time Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 5-15 | 38 | 3444.80 | 90.65 | 100.0% | 10.9 |
| 15-30 | 27 | 870.10 | 32.23 | 100.0% | 19.1 |
| <5 | 27 | 1887.50 | 69.91 | 100.0% | 1.2 |
| 60-180 | 7 | 264.00 | 37.71 | 100.0% | 90.2 |
| 30-60 | 5 | 168.50 | 33.70 | 100.0% | 38.0 |
| 180-720 | 1 | 450.00 | 450.00 | 100.0% | 198.3 |

## By VIX Regime

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| disabled | 105 | 7084.90 | 67.48 | 100.0% | 12.0 |

## By Option Data State

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 79 | 5409.70 | 68.48 | 100.0% | 12.0 |
| VALID_1DTE_ONLY | 20 | 1305.00 | 65.25 | 100.0% | 14.1 |
| STALE_0DTE | 5 | 162.80 | 32.56 | 100.0% | 23.3 |
| EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 |

## By Active Profile Set

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 79 | 5409.70 | 68.48 | 100.0% | 12.0 |
| VALID_1DTE_ONLY | 20 | 1305.00 | 65.25 | 100.0% | 14.1 |
| STALE_0DTE | 5 | 162.80 | 32.56 | 100.0% | 23.3 |
| EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 |

## Monthly Summary

| Month | Trades | PnL | Avg PnL | Median Hold Min | Exposure Hours | PnL/Exposure Hour | Slow >=12h |
| --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| 2026-06 | 68 | 4321.00 | 63.54 | 10.9 | 16.2 | 266.45 | 0 |
| 2026-07 | 37 | 2763.90 | 74.70 | 13.2 | 19.0 | 145.40 | 0 |

## TP Target Distribution

| Target | Trades | PnL | Avg PnL | Median Hold Min |
| --- | ---: | ---: | ---: | ---: |
| 2.34 | 1 | 84.00 | 84.00 | 3.0 |
| 2.40 | 32 | 1200.30 | 37.51 | 5.0 |
| 2.49 | 1 | 45.50 | 45.50 | 20.6 |
| 2.57 | 1 | 93.60 | 93.60 | 5.3 |
| 2.63 | 1 | 39.60 | 39.60 | 12.0 |
| 2.99 | 1 | 105.00 | 105.00 | 8.5 |
| 3.00 | 20 | 1305.00 | 65.25 | 14.1 |
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
| 3.60 | 6 | 545.30 | 90.88 | 9.5 |
| 4.00 | 2 | 36.00 | 18.00 | 27.2 |
| 6.00 | 3 | 278.40 | 92.80 | 23.3 |
| 12.00 | 5 | 985.60 | 197.12 | 16.0 |
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
