# SPX500 IB Trend Scalper Analysis

- Metrics file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_018/execution-metrics.csv`
- Backtest file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_018/launcher/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm.json`
- Completed paired trades: 96
- Entry signals: 96
- Approx open/unpaired entry signals: 0
- Position/order maintenance waits: 12123
- Total paired trade PnL: 6193.00
- Win rate: 100.0%
- Realized loss trades: 0
- Median hold: 12.0 minutes
- Average hold: 33.1 minutes

## Lean Runtime Statistics
- Equity: $106,193.00
- Net Profit: $6,193.00
- Return: 6.19 %
- Probabilistic Sharpe Ratio: 100.000%
- Volume: $40,870,459.60

## Risk And Efficiency
- Exposure hours: 53.0
- PnL per exposure hour: 116.83
- Calendar span days: 12.3
- PnL per calendar day: 502.78
- Trades per calendar day: 7.79
- Exposure share of calendar time: 17.9%
- Growth quality score: 9186.3
- VIX stale at entry: 0.0%
- ES stale rows: 9.4%
- Waiting ES VWAP rows: 0.0%
- Trade-health exit signals: 0
- Trade-health tighten signals: 0
- Slow trades held >= 12 hours: 1 (1.0%)
- Slow exposure hours: 20.0
- Slow PnL per exposure hour: 1.75
- Fast <15m trades: 57
- Fast PnL per exposure hour: 732.99

## Pullback Broken Structure Veto
- Blocked signal rows: 1088
- Blocked by profile: `{"charm_pin_pullback_long": 1040, "pullback_long": 48}`
- Blocked net profit / worst MAE: not available for hard-blocked signals because they do not become completed trades.
- Remaining trades by profile: `{"breakout_long_1dte": 20, "breakout_long_no_0dte": 3, "charm_pin_pullback_long": 33, "charm_wall_breakaway_long": 5, "pullback_long": 25, "pullback_long_no_0dte": 3, "squeeze_long": 7}`
- Remaining PnL by profile: `{"breakout_long_1dte": 1300.8999999999915, "breakout_long_no_0dte": 278.40000000001237, "charm_pin_pullback_long": 1216.3000000001175, "charm_wall_breakaway_long": 973.0999999999876, "pullback_long": 1728.0000000001155, "pullback_long_no_0dte": 91.79999999999018, "squeeze_long": 604.5}`

## Lean Portfolio And Trade Statistics
- Portfolio: sharpeRatio=31.2116, sortinoRatio=0, alpha=0, beta=0, informationRatio=31.9513, drawdown=0.020
- Trades: sharpeRatio=0.9497, averageMAE=-119.7380, averageMFE=84.9005, largestMAE=-2026.5, largestMFE=449.75, maximumIntraTradeDrawdown=-2142.0

## Strategy Profile Performance

| Strategy | Enabled | Data State | Profile Set | Trades | PnL | Avg PnL | Win Rate | Median Hold Min | Exposure Hrs | PnL/Exposure Hr | Slow >=12h | Worst MAE | Median MFE | Median TP |
| --- | --- | --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| pullback_long | true | VALID_0DTE | VALID_0DTE | 25 | 1728.00 | 69.12 | 100.0% | 12.7 | 29.1 | 59.42 | 1 | -2026.50 | 93.60 | 3.76 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 1300.90 | 65.04 | 100.0% | 14.1 | 7.7 | 168.23 | 0 | -375.70 | 79.88 | 3.00 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 33 | 1216.30 | 36.86 | 100.0% | 5.1 | 7.1 | 170.46 | 0 | -527.00 | 42.50 | 2.40 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 5 | 973.10 | 194.62 | 100.0% | 16.0 | 4.2 | 231.38 | 0 | -346.80 | 146.20 | 12.00 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 7 | 604.50 | 86.36 | 100.0% | 12.1 | 1.8 | 344.83 | 0 | -194.25 | 66.30 | 38.75 |
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
| pullback_long | true | VALID_0DTE | VALID_0DTE | 25 | 49.57 | 6.34 | 49.20 | 21.81 | 69.8 | 1 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 66.60 | 5.83 | 70.56 | 26.99 | 23.2 | 0 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 33 | 65.52 | 29.56 | 49.23 | 18.94 | 13.0 | 0 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 5 | 75.96 | 21.06 | 57.99 | 17.35 | 50.5 | 0 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 7 | 69.68 | 13.69 | 67.57 | 21.40 | 15.0 | 0 |
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
- MAE: average -121.00, median -73.10, worst -2026.50
- MFE: average 84.90, median 55.95, best 449.75
- Average MFE / absolute MAE: 0.70

## Intratrade Path
- Trades with path stats: 96; with intratrade price samples: 96
- Went positive before max adverse: 52.1%
- MFE happened before MAE: 12.5%
- TP touched before MAE: 2.1%
- Median MFE available before MAE: 0.05 points
- Median first TP touch: 4.1 minutes
- Median first +1.5 points: 2.9 minutes
- First 15m MFE/MAE medians: 2.40 / -2.00 points

## Worst Tail Trade Autopsy
- Worst tail entry: `2026-06-30T19:14:04+00:00` -> `2026-07-01T15:15:01+00:00`.
- Strategy/profile: `pullback_long` / `pullback_long`. PnL 35.00, MAE -2026.50, MFE 115.50, hold 1201.0 minutes.
- Profile context: `pullback_long` produced 25 trades, PnL 1728.00, 1 slow >=12h trades, and 27.9% of total PnL.
- Entry state: setup=47.32, ES-VWAP=7.66, VWAP slope=0.0009, VWAP acceleration=-0.0003, RSI=51.19, ADX=12.19, structure score=4.00, higher-low=1.25, higher-high=-1.00, pullback-from-high=1.75, rolling-high distance=2.75.
- Guard state: setup allowed=`True`, entry veto allowed=`True`, veto points=3.00, slow-risk points=0.00.
- Existing warning reason: setup quality 47.32 <= 50.00; ES structure higher-high -1.00 < 0.00; ADX 12.19 <= 18.00.
- Strategy selection reason: VALID_0DTE ordered router; ordered ES pullback: trendPrice=7544.75, ema=7544.80, distance=7.66, adx=12.19, rsi=51.19, structure=4.
- Intratrade path: path MFE 3.10, path MAE -57.90, MFE before MAE=`True`, TP reached=`False`.
- Surgical setup floor check: `setup_quality_score >= 47.4` would block this trade, keep 88 trades, retain 90.3% PnL, and leave worst MAE -527.00. It would block 8 trades total.
- Candidate guards that would have blocked this tail:
  - `option_strike_map_target_3_distance >= 1`: kept 89 trades, retained 95.7% PnL, kept worst MAE -527.00.
  - `option_strike_map_target_3_distance >= 2`: kept 77 trades, retained 85.0% PnL, kept worst MAE -527.00.
  - `setup_quality_score >= 50`: kept 80 trades, retained 82.5% PnL, kept worst MAE -527.00.

## Unscanned Feature Coverage
- Present trade columns: 144, scanned columns: 144, unscanned columns: 0
- No unscanned feature columns found. Good coverage for all present trade fields.

## Candidate Entry Quality Filters

| Scope | Condition | Kept | Blocked | Kept PnL | PnL Loss | Retained PnL | Slow Removed | Slow Left | Kept PnL/Exposure Hr | Kept Worst MAE | Score |
| --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| all_trades | `option_strike_map_target_3_distance >= 1` | 89 | 7 | 5923.80 | 269.20 | 95.7% | 1 | 0 | 197.69 | -527.00 | 160.5 |
| all_trades | `option_strike_map_target_3_distance >= 2` | 77 | 19 | 5262.00 | 931.00 | 85.0% | 1 | 0 | 188.88 | -527.00 | 39.5 |
| all_trades | `setup_quality_score >= 50` | 80 | 16 | 5110.20 | 1082.80 | 82.5% | 1 | 0 | 189.03 | -527.00 | 12.7 |
| all_trades | `setup_quality_score >= 55` | 70 | 26 | 4447.20 | 1745.80 | 71.8% | 1 | 0 | 188.94 | -527.00 | -108.2 |
| all_trades | `option_strike_map_target_3_distance >= 3` | 61 | 35 | 4403.90 | 1789.10 | 71.1% | 1 | 0 | 229.35 | -527.00 | -117.3 |
| all_trades | `rsi_slope >= 0` | 60 | 36 | 4281.50 | 1911.50 | 69.1% | 1 | 0 | 192.16 | -392.00 | -131.4 |
| all_trades | `es_vwap_slope >= 0.02` | 61 | 35 | 4121.80 | 2071.20 | 66.6% | 1 | 0 | 190.51 | -527.00 | -168.1 |

## Hidden MAE Signature Candidates

| Condition | Bad Trades | Bad Blocked | Good Blocked | Kept Trades | Kept PnL | PnL Loss | Retained PnL | Kept Worst MAE | Score |
| --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| `es_structure_rising_vwap != "False"` | 19 | 6 | 11 | 79 | 4834.00 | 1359.00 | 78.1% | -2026.50 | 48736.0 |
| `long_strategy != "breakout_long_1dte"` | 19 | 6 | 14 | 76 | 4892.10 | 1300.90 | 79.0% | -2026.50 | 48730.1 |
| `strategy_profile != "breakout_long_1dte"` | 19 | 6 | 14 | 76 | 4892.10 | 1300.90 | 79.0% | -2026.50 | 48730.1 |
| `long_strategy != "pullback_long"` | 19 | 6 | 19 | 71 | 4465.00 | 1728.00 | 72.1% | -527.00 | 30621.5 |
| `strategy_profile != "pullback_long"` | 19 | 6 | 19 | 71 | 4465.00 | 1728.00 | 72.1% | -527.00 | 30621.5 |
| `path_half_tp_touch_minutes >= 0.383333` | 19 | 12 | 24 | 60 | 4396.00 | 1797.00 | 71.0% | -2026.50 | 524.8 |
| `path_half_tp_touch_minutes >= 0.183333` | 19 | 11 | 22 | 63 | 4562.30 | 1630.70 | 73.7% | -2026.50 | 484.0 |
| `es_structure_pullback_from_high <= 3.75` | 19 | 8 | 22 | 66 | 4395.80 | 1797.20 | 71.0% | -2026.50 | 233.0 |
| `option_strike_map_target_1_strike >= 7475` | 19 | 6 | 10 | 80 | 5076.60 | 1116.40 | 82.0% | -2026.50 | 226.2 |
| `option_strike_map_atm_strike <= 7540` | 19 | 6 | 13 | 77 | 5086.50 | 1106.50 | 82.1% | -527.00 | 223.4 |
| `take_profit_price <= 7524.3` | 19 | 5 | 10 | 81 | 5456.50 | 736.50 | 88.1% | -527.00 | 220.9 |
| `option_strike_map_underlying_price <= 7540.75` | 19 | 6 | 16 | 74 | 5014.50 | 1178.50 | 81.0% | -527.00 | 206.0 |

## Upside TP Extension Candidates
| all | No upside TP extension candidates found. |  |  |  |  |  |  |  |  |  |  |

## Event Counts
- blocked: 32156
- position_wait: 12123
- stale_es_vwap: 4867
- trade_risk_extend_signal: 1192
- trade_risk_tighten_signal: 464
- order_event: 437
- waiting_spx_quote: 415
- entry_signal: 96

## Blocked Gate Counts
- setup_quality_allowed: 12910 (disabled=12910)
- above_vwap_confirmed: 8703 (disabled=8703)
- above_vwap: 7862 (disabled=7862)
- es_structure_allowed: 7233 (disabled=7233)
- pullback: 5823 (disabled=5823)
- momentum: 3613 (disabled=3613)
- es_vwap_slope_allowed: 3245 (disabled=3245)
- es_vwap_max_distance_allowed: 3181 (disabled=3181)
- trend_strength: 2871 (disabled=2871)
- es_vwap_acceleration_allowed: 1490 (disabled=1490)
- es_rolling_high_allowed: 417 (disabled=417)
- indicator_slope_allowed: 155 (disabled=155)

## By UTC Hour

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 13 | 10 | 490.80 | 49.08 | 100.0% | 0.4 |
| 14 | 9 | 729.40 | 81.04 | 100.0% | 1.9 |
| 8 | 8 | 1169.60 | 146.20 | 100.0% | 14.3 |
| 12 | 7 | 262.30 | 37.47 | 100.0% | 12.2 |
| 15 | 7 | 453.10 | 64.73 | 100.0% | 11.9 |
| 1 | 6 | 509.10 | 84.85 | 100.0% | 3.0 |
| 9 | 6 | 324.80 | 54.13 | 100.0% | 14.0 |
| 11 | 5 | 178.20 | 35.64 | 100.0% | 12.0 |
| 19 | 5 | 166.30 | 33.26 | 100.0% | 33.9 |
| 5 | 5 | 198.30 | 39.66 | 100.0% | 20.6 |
| 18 | 4 | 200.10 | 50.03 | 100.0% | 10.4 |
| 2 | 4 | 211.40 | 52.85 | 100.0% | 48.6 |
| 22 | 4 | 392.90 | 98.23 | 100.0% | 14.9 |
| 6 | 4 | 215.10 | 53.78 | 100.0% | 14.2 |
| 0 | 3 | 174.40 | 58.13 | 100.0% | 12.1 |
| 7 | 3 | 181.20 | 60.40 | 100.0% | 12.1 |
| 23 | 2 | 70.00 | 35.00 | 100.0% | 29.5 |
| 3 | 2 | 150.50 | 75.25 | 100.0% | 15.9 |
| 10 | 1 | 35.00 | 35.00 | 100.0% | 14.0 |
| 17 | 1 | 80.50 | 80.50 | 100.0% | 12.0 |

## By RSI Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <55 | 51 | 2724.20 | 53.42 | 100.0% | 10.1 |
| 55-60 | 15 | 1197.50 | 79.83 | 100.0% | 16.0 |
| >=75 | 11 | 1006.40 | 91.49 | 100.0% | 9.9 |
| 60-65 | 7 | 345.90 | 49.41 | 100.0% | 25.7 |
| 70-75 | 7 | 377.00 | 53.86 | 100.0% | 17.3 |
| 65-70 | 5 | 542.00 | 108.40 | 100.0% | 16.4 |

## By ADX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <20 | 38 | 2355.10 | 61.98 | 100.0% | 12.0 |
| 20-25 | 19 | 1463.60 | 77.03 | 100.0% | 12.2 |
| 25-30 | 18 | 1070.40 | 59.47 | 100.0% | 13.4 |
| 30-40 | 17 | 1075.00 | 63.24 | 100.0% | 12.0 |
| 40-50 | 3 | 190.40 | 63.47 | 100.0% | 4.8 |
| >=50 | 1 | 38.50 | 38.50 | 100.0% | 17.0 |

## By VIX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| missing | 96 | 6193.00 | 64.51 | 100.0% | 12.0 |

## By ES VWAP Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.25 | 92 | 5611.50 | 60.99 | 100.0% | 12.0 |
| 0.25-0.5 | 3 | 564.50 | 188.17 | 100.0% | 9.4 |
| 0.5-1 | 1 | 17.00 | 17.00 | 100.0% | 29.9 |

## By ES VWAP Acceleration Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.05 | 46 | 3011.50 | 65.47 | 100.0% | 12.1 |
| -0.05-0 | 32 | 1750.90 | 54.72 | 100.0% | 9.4 |
| 0.1-0.25 | 10 | 1037.70 | 103.77 | 100.0% | 15.7 |
| 0.05-0.1 | 5 | 252.40 | 50.48 | 100.0% | 17.3 |
| >=0.25 | 2 | 53.00 | 26.50 | 100.0% | 55.9 |
| -0.25--0.1 | 1 | 87.50 | 87.50 | 100.0% | 6.7 |

## By ES Rolling High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-6 | 23 | 912.70 | 39.68 | 100.0% | 2.3 |
| 2-4 | 21 | 1087.50 | 51.79 | 100.0% | 15.3 |
| 0-1 | 19 | 1586.40 | 83.49 | 100.0% | 13.2 |
| 6-8 | 13 | 1377.70 | 105.98 | 100.0% | 12.0 |
| 8-12 | 8 | 341.00 | 42.62 | 100.0% | 15.7 |
| 1-2 | 6 | 365.20 | 60.87 | 100.0% | 18.6 |
| 12-20 | 5 | 487.50 | 97.50 | 100.0% | 6.5 |
| >=20 | 1 | 35.00 | 35.00 | 100.0% | 19.1 |

## By ES Rolling High Minutes Since

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 20-30 | 31 | 2162.00 | 69.74 | 100.0% | 8.7 |
| <1 | 23 | 1785.60 | 77.63 | 100.0% | 14.7 |
| 1-3 | 12 | 900.10 | 75.01 | 100.0% | 14.7 |
| 10-20 | 12 | 482.30 | 40.19 | 100.0% | 15.4 |
| 5-10 | 10 | 465.90 | 46.59 | 100.0% | 11.9 |
| 3-5 | 8 | 397.10 | 49.64 | 100.0% | 10.2 |

## By RSI Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| >=3 | 29 | 2208.00 | 76.14 | 100.0% | 13.2 |
| 0-1 | 19 | 938.50 | 49.39 | 100.0% | 6.5 |
| -1-0 | 10 | 643.20 | 64.32 | 100.0% | 14.1 |
| -3--2 | 8 | 323.80 | 40.48 | 100.0% | 6.8 |
| <-3 | 8 | 398.30 | 49.79 | 100.0% | 5.8 |
| 1-2 | 6 | 491.70 | 81.95 | 100.0% | 13.5 |
| 2-3 | 6 | 643.30 | 107.22 | 100.0% | 17.8 |
| -2--1 | 5 | 191.90 | 38.38 | 100.0% | 21.3 |
| missing | 5 | 354.30 | 70.86 | 100.0% | 10.1 |

## By ADX Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-1 | 36 | 2435.50 | 67.65 | 100.0% | 11.9 |
| -1-0 | 28 | 1956.20 | 69.86 | 100.0% | 15.4 |
| 1-2 | 19 | 1190.10 | 62.64 | 100.0% | 8.4 |
| -2--1 | 8 | 256.90 | 32.11 | 100.0% | 30.0 |
| missing | 5 | 354.30 | 70.86 | 100.0% | 10.1 |

## By ES Higher-Low Distance Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 2-4 | 28 | 1367.40 | 48.84 | 100.0% | 15.9 |
| 4-8 | 20 | 2158.40 | 107.92 | 100.0% | 10.9 |
| 1-2 | 19 | 903.60 | 47.56 | 100.0% | 12.0 |
| >=8 | 14 | 1041.00 | 74.36 | 100.0% | 14.4 |
| 0-0.5 | 8 | 319.80 | 39.98 | 100.0% | 1.5 |
| 0.5-1 | 7 | 402.80 | 57.54 | 100.0% | 12.0 |

## By ES Structure Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4 | 36 | 2301.20 | 63.92 | 100.0% | 12.0 |
| 3 | 31 | 2282.70 | 73.64 | 100.0% | 12.7 |
| 5 | 28 | 1575.10 | 56.25 | 100.0% | 11.9 |
| 2 | 1 | 34.00 | 34.00 | 100.0% | 12.1 |

## By ES Structure Pullback From High

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-2 | 41 | 3100.20 | 75.61 | 100.0% | 14.7 |
| 2-4 | 25 | 1295.60 | 51.82 | 100.0% | 12.0 |
| 4-8 | 25 | 1573.70 | 62.95 | 100.0% | 9.4 |
| 8-12 | 5 | 223.50 | 44.70 | 100.0% | 17.3 |

## By ES Structure Higher-Low Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 35 | 2381.60 | 68.05 | 100.0% | 14.0 |
| 2-4 | 16 | 591.00 | 36.94 | 100.0% | 18.1 |
| 1-2 | 11 | 786.10 | 71.46 | 100.0% | 13.2 |
| 0.5-1 | 10 | 815.70 | 81.57 | 100.0% | 3.2 |
| 4-8 | 10 | 540.60 | 54.06 | 100.0% | 7.4 |
| >=8 | 8 | 682.50 | 85.31 | 100.0% | 12.0 |
| 0-0.5 | 6 | 395.50 | 65.92 | 100.0% | 14.2 |

## By ES Structure Higher-High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 35 | 2220.00 | 63.43 | 100.0% | 12.0 |
| 2-4 | 18 | 1249.20 | 69.40 | 100.0% | 10.6 |
| 4-8 | 14 | 1076.00 | 76.86 | 100.0% | 12.0 |
| 1-2 | 12 | 678.80 | 56.57 | 100.0% | 21.8 |
| >=8 | 8 | 524.00 | 65.50 | 100.0% | 13.4 |
| 0-0.5 | 5 | 228.10 | 45.62 | 100.0% | 20.6 |
| 0.5-1 | 4 | 216.90 | 54.23 | 100.0% | 12.0 |

## By ES Structure VWAP Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 34 | 2246.60 | 66.08 | 100.0% | 14.9 |
| >=24 | 29 | 1028.50 | 35.47 | 100.0% | 2.8 |
| 8-12 | 11 | 1209.90 | 109.99 | 100.0% | 23.5 |
| 12-16 | 7 | 425.10 | 60.73 | 100.0% | 12.0 |
| 2-4 | 7 | 570.70 | 81.53 | 100.0% | 6.7 |
| 16-24 | 5 | 571.30 | 114.26 | 100.0% | 9.4 |
| 0-2 | 3 | 140.90 | 46.97 | 100.0% | 12.0 |

## By Setup Quality Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 50-60 | 29 | 1897.70 | 65.44 | 100.0% | 12.0 |
| 60-70 | 22 | 1224.30 | 55.65 | 100.0% | 12.0 |
| 70-80 | 18 | 1438.10 | 79.89 | 100.0% | 12.0 |
| 40-50 | 16 | 1082.80 | 67.68 | 100.0% | 14.0 |
| 80-90 | 11 | 550.10 | 50.01 | 100.0% | 16.6 |

## By Entry-Veto Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 2-3 | 22 | 893.60 | 40.62 | 100.0% | 15.8 |
| 1-2 | 21 | 1492.50 | 71.07 | 100.0% | 12.1 |
| 3-4 | 19 | 1041.20 | 54.80 | 100.0% | 12.0 |
| 4-5 | 14 | 1492.50 | 106.61 | 100.0% | 8.0 |
| 5-6 | 13 | 643.00 | 49.46 | 100.0% | 12.0 |
| <1 | 7 | 630.20 | 90.03 | 100.0% | 12.0 |

## By Slow-Risk Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <1 | 96 | 6193.00 | 64.51 | 100.0% | 12.0 |

## By Entry Risk Tier

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| standard | 96 | 6193.00 | 64.51 | 100.0% | 12.0 |

## By ES Reclaim Current Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 34 | 2246.60 | 66.08 | 100.0% | 14.9 |
| >=24 | 29 | 1028.50 | 35.47 | 100.0% | 2.8 |
| 8-12 | 11 | 1209.90 | 109.99 | 100.0% | 23.5 |
| 12-16 | 7 | 425.10 | 60.73 | 100.0% | 12.0 |
| 2-4 | 7 | 570.70 | 81.53 | 100.0% | 6.7 |
| 16-24 | 5 | 571.30 | 114.26 | 100.0% | 9.4 |
| 0-2 | 3 | 140.90 | 46.97 | 100.0% | 12.0 |

## By SPX EMA20 Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 62 | 3456.10 | 55.74 | 100.0% | 11.9 |
| 2-4 | 12 | 1130.50 | 94.21 | 100.0% | 19.9 |
| 4-6 | 8 | 583.50 | 72.94 | 100.0% | 10.9 |
| 8-12 | 5 | 650.10 | 130.02 | 100.0% | 12.1 |
| >=12 | 5 | 230.80 | 46.16 | 100.0% | 16.6 |
| 1-2 | 4 | 142.00 | 35.50 | 100.0% | 54.7 |

## By Hold-Time Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 5-15 | 32 | 2796.60 | 87.39 | 100.0% | 12.0 |
| 15-30 | 26 | 832.00 | 32.00 | 100.0% | 19.5 |
| <5 | 25 | 1723.90 | 68.96 | 100.0% | 1.2 |
| 60-180 | 7 | 263.00 | 37.57 | 100.0% | 90.2 |
| 30-60 | 4 | 105.00 | 26.25 | 100.0% | 34.6 |
| 180-720 | 1 | 437.50 | 437.50 | 100.0% | 198.3 |
| >=720 | 1 | 35.00 | 35.00 | 100.0% | 1201.0 |

## By VIX Regime

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| disabled | 96 | 6193.00 | 64.51 | 100.0% | 12.0 |

## By Option Data State

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 70 | 4521.90 | 64.60 | 100.0% | 12.0 |
| VALID_1DTE_ONLY | 20 | 1300.90 | 65.04 | 100.0% | 14.1 |
| STALE_0DTE | 5 | 162.80 | 32.56 | 100.0% | 23.3 |
| EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 |

## By Active Profile Set

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 70 | 4521.90 | 64.60 | 100.0% | 12.0 |
| VALID_1DTE_ONLY | 20 | 1300.90 | 65.04 | 100.0% | 14.1 |
| STALE_0DTE | 5 | 162.80 | 32.56 | 100.0% | 23.3 |
| EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 |

## Monthly Summary

| Month | Trades | PnL | Avg PnL | Median Hold Min | Exposure Hours | PnL/Exposure Hour | Slow >=12h |
| --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| 2026-06 | 66 | 4110.50 | 62.28 | 12.0 | 16.3 | 251.90 | 0 |
| 2026-07 | 30 | 2082.50 | 69.42 | 16.4 | 36.7 | 56.76 | 1 |

## TP Target Distribution

| Target | Trades | PnL | Avg PnL | Median Hold Min |
| --- | ---: | ---: | ---: | ---: |
| 2.40 | 33 | 1216.30 | 36.86 | 5.1 |
| 2.94 | 1 | 45.50 | 45.50 | 20.6 |
| 3.00 | 20 | 1300.90 | 65.04 | 14.1 |
| 3.02 | 1 | 111.60 | 111.60 | 5.7 |
| 3.08 | 1 | 39.60 | 39.60 | 12.0 |
| 3.09 | 1 | 55.80 | 55.80 | 11.9 |
| 3.40 | 1 | 119.00 | 119.00 | 6.5 |
| 3.44 | 1 | 122.50 | 122.50 | 10.1 |
| 3.47 | 2 | 100.80 | 50.40 | 51.1 |
| 3.59 | 1 | 133.00 | 133.00 | 6.7 |
| 3.64 | 1 | 35.00 | 35.00 | 26.0 |
| 3.71 | 1 | 133.00 | 133.00 | 4.0 |
| 3.75 | 1 | 133.20 | 133.20 | 0.1 |
| 3.76 | 2 | 69.00 | 34.50 | 17.2 |
| 3.78 | 1 | 36.00 | 36.00 | 29.9 |
| 3.79 | 1 | 35.00 | 35.00 | 155.4 |
| 3.88 | 1 | 46.80 | 46.80 | 12.7 |
| 3.89 | 1 | 80.50 | 80.50 | 12.0 |
| 3.91 | 1 | 101.50 | 101.50 | 12.0 |
| 3.93 | 1 | 35.00 | 35.00 | 1201.0 |
| 4.00 | 2 | 36.00 | 18.00 | 27.2 |
| 4.01 | 1 | 36.00 | 36.00 | 15.6 |
| 4.03 | 1 | 36.00 | 36.00 | 23.6 |
| 4.29 | 1 | 54.00 | 54.00 | 12.0 |
| 4.30 | 1 | 150.50 | 150.50 | 1.9 |
| 4.32 | 1 | 38.50 | 38.50 | 17.0 |
| 4.50 | 1 | 36.00 | 36.00 | 23.5 |
| 6.00 | 3 | 278.40 | 92.80 | 23.3 |
| 12.00 | 5 | 973.10 | 194.62 | 16.0 |
| 14.06 | 1 | 34.00 | 34.00 | 12.1 |
| 28.44 | 1 | 112.20 | 112.20 | 12.0 |
| 38.75 | 2 | 125.80 | 62.90 | 14.7 |
| 48.62 | 2 | 70.00 | 35.00 | 19.9 |
| 55.78 | 1 | 262.50 | 262.50 | 12.0 |

## Slow Trade Fingerprint
- Trades held >= 12 hours: 1 (1.0%)
- Slow-trade median hold: 1201.0 minutes
- Slow-trade total PnL: 35.00
- rsi14: slow median 51.19, fast<15m median 51.32
- adx14: slow median 12.19, fast<15m median 22.91
- es_minus_vwap: slow median 7.66, fast<15m median 13.23
- price_minus_ema20: slow median -23.10, fast<15m median -59.47
- es_structure_score: slow median 4.00, fast<15m median 4.00
- es_structure_pullback_from_high: slow median 1.75, fast<15m median 2.50
- es_structure_higher_low_distance: slow median 1.25, fast<15m median 0.75
- es_structure_higher_high_distance: slow median -1.00, fast<15m median 1.25
- es_structure_vwap_distance: slow median 7.66, fast<15m median 13.23
- es_vwap_acceleration: slow median -0.00, fast<15m median 0.00
- es_rolling_high_distance: slow median 2.75, fast<15m median 4.25
- es_rolling_high_minutes_since: slow median 12.97, fast<15m median 6.17
- rsi_slope: slow median -0.02, fast<15m median 0.83
- adx_slope: slow median -0.66, fast<15m median 0.39
- setup_quality_score: slow median 47.32, fast<15m median 62.13
- setup_quality_take_profit_boost: slow median 0.00, fast<15m median 0.12
- entry_veto_points: slow median 3.00, fast<15m median 3.00
- slow_risk_points: slow median 0.00, fast<15m median 0.00
- es_reclaim_current_distance: slow median 7.66, fast<15m median 13.23
- spx_ema20_distance: slow median -0.05, fast<15m median -0.20

## Interpretation Notes
- This strategy exits with take-profit orders only, so a high win rate can hide capital being tied up for a long time.
- The best setting candidates are usually found by reducing slow-to-profit entries, not simply maximizing raw entry count.
- Focus first on buckets with low average PnL or long median hold time, then test stricter RSI/ADX/VWAP/VIX filters against those buckets.
